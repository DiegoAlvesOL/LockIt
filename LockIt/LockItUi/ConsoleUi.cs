using LockIt.LockItInfra;

namespace LockIt.LockItUi;
using LockItCore;



/// <summary>
/// Classe estática responsável por gerenciar a interface do usuário no console.
/// Permite gerar senhas, capturar credenciais e listar credenciais salvas.
/// </summary>
public static class ConsoleUi
{
    
    /// <summary>
    /// Inicia o fluxo principal do aplicativo LockIt no console.
    /// </summary>
    public static void Start()
    {
        credentials = JsonLoader.Load();
        while (true)
        {
            Console.Clear();
            ShowWelcomeMessage();
            Console.WriteLine("Enter your choice");
            string selection = Console.ReadLine().Trim();

            if (selection == "0")
            {
                Console.WriteLine("Thank you for using LockIt.");
                break;
            }
            else if (selection == "1")
            {
                int length = AskPasswordLength();
                var options = GetCharacterOptions();
                string charset = "";

                if (options.includeDigits) charset = charset + CharacterSets.Digits;
                if (options.includeLowerCase) charset = charset + CharacterSets.LowerCaseLetters;
                if (options.includeUpperCase) charset = charset + CharacterSets.UpperCaseLetters;
                if (options.includeSpecialChars) charset = charset + CharacterSets.SpecialCharacters;
                
                
                var generator = new PasswordGenerator(charset);
                string password = generator.GeneratePassword(length);
                
                var credential = CaptureCredentialData(password);
                credential.CreatedAt = DateTime.UtcNow;
                
                credentials.Add(credential);
                
                JsonStorage.Save(credential);
                
                DisplayPassword(password);
            }
            else if (selection == "2")
            {
                ListCredentials();
            }
            else
            {
                Console.WriteLine("Option invalid. Please try again");
                Console.ReadKey();
            }
        }
    }
    public static void ShowWelcomeMessage()
    {
        Console.WriteLine("+===========================+");
        Console.WriteLine("|     WELCOME TO LOCKIT     |");
        Console.WriteLine("+===========================+");
        Console.WriteLine("| 1 - Generate password     |");
        Console.WriteLine("| 2 - List credentials      |");
        Console.WriteLine("| 0 - To exit the software  |");
        Console.WriteLine("+===========================+");
    }

    public static void DisplayPassword(string password)
    {
        Console.WriteLine($"Your password is: {password}");
        Console.WriteLine("Credential saved successfully!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    public static int AskPasswordLength()
    {
        int length = 0;
        bool validInput = false;

        while (!validInput)
        {
            Console.WriteLine("Enter the desired password length (4 - 100): ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out length))
            {
                if (length >= 4 && length <= 100)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 4 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please type only numbers.");
            }
        }
        return length;
    }

    /// <summary>
    /// Solicita ao usuário quais tipos de caracteres incluir na senha.
    /// </summary>
    /// <returns>
    /// Tupla booleana indicando se dígitos, letras minúsculas, letras maiúsculas e caracteres especiais devem ser incluídos.
    /// </returns>
    public static (bool includeDigits, bool includeLowerCase, bool includeUpperCase, bool includeSpecialChars)
        GetCharacterOptions()
    {
        bool includeDigits = AskYesNo("Include digits (0-9)? (y/n): ");
        bool includeLowerCase = AskYesNo("Include lowercase letters (a-z)? (y/n): ) ");
        bool includeUpperCase = AskYesNo("Include uppercase letters (A-Z)? (y/n): ");
        bool includeSpecialChars = AskYesNo("Include special characters (%$#@&...)? (y/n): ");

        if (!includeDigits && !includeLowerCase && !includeUpperCase && !includeSpecialChars)
        {
            Console.WriteLine("You must select at least one character set.");
            return GetCharacterOptions();
        }

        return (includeDigits, includeLowerCase, includeUpperCase, includeSpecialChars);
    }

    public static bool AskYesNo(string message)
    {
        Console.WriteLine(message);
        string answer = Console.ReadLine();
        answer = answer.Trim().ToLower();

        if (answer == "y")
        {
            return true;
        }
        else if (answer == "n")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please type 'y' or 'n'. ");
            return AskYesNo(message);
        }
    }

    private static List<Credential> credentials = new List<Credential>();

    public static Credential CaptureCredentialData(string password)
    {
        Console.WriteLine("Enter with name or address of service (e.g., Gmail, https://example.com): )");
        string service = Console.ReadLine().Trim().ToLower();
        
        Console.WriteLine("Enter the email/username for this service: ");
        string userName = Console.ReadLine().Trim().ToLower();
        
        Console.WriteLine("Add any notes? (optional, press enter to skip): ");
        string note = Console.ReadLine().Trim().ToLower();

        return new Credential
        {
            Service = service,
            UserName = userName,
            Password = password,
            Notes = note
        };
    }

    public static void ListCredentials()
    {
        if (credentials.Count == 0)
        {
            Console.WriteLine("No credentials saved yet.");
        }
        else
        {
            foreach (var credential in credentials)
            {
                Console.WriteLine("======================================");
                Console.WriteLine($"Service: {credential.Service}");
                Console.WriteLine($"UserName: {credential.UserName}");
                Console.WriteLine($"Password: {credential.Password}");
                Console.WriteLine($"Created at: {credential.CreatedAt}");
                Console.WriteLine($"Notes: {credential.Notes}");
                Console.WriteLine("======================================");
            }
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}