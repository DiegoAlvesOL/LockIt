namespace LockIt.LockItCore;


/// <summary>
/// Classe responsável por gerar senhas aleatórias com base em um conjunto de caracteres permitido.
/// </summary>
public class PasswordGenerator
{

    public string AllowedCharacters { get; }

    private readonly Random random = new();

    public PasswordGenerator(string charset)
    {
        AllowedCharacters = charset;
    }

    public string GeneratePassword(int length)
    {
        string password = "";

        for (int currentPosition = 0; currentPosition < length; currentPosition++)
        {
            int randomIndex = random.Next(AllowedCharacters.Length);
            char selectedCharacter = AllowedCharacters[randomIndex];
            password = password + selectedCharacter;
        }
        return password;
    }
}