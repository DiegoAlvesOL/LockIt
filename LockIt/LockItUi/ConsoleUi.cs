namespace LockIt.LockItUi;
using LockIt.LockItCore;
public static class ConsoleUi
{
    public static void Start()
    {
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
                
                var generator = new PasswordGenerator(CharacterSets.Digits +
                                                      CharacterSets.Digits +
                                                      CharacterSets.UpperCaseLetters +
                                                      CharacterSets.SpecialCharacters);
                string password = generator.GeneratePassword(length);
                DisplayPassword(password);
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
        Console.WriteLine("| 0 - To exit the software  |");
        Console.WriteLine("+===========================+");
    }

    //Old method to Ask the length para gerar o usuário.
    // public static int AskPasswordLength()
    // {
    //     Console.WriteLine("What is the length of your password? (e.g., 4, 8, 12): ");
    //     int length = Convert.ToInt32(Console.ReadLine()?.Trim());
    //     return length;
    // }

    public static void DisplayPassword(string password)
    {
        Console.WriteLine($"Your password id: {password}");
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
    
    
}

