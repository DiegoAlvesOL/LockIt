namespace LockIt.LockItCore;

public class PasswordGenerator
{

    public string AllowedCharacters { get; }

    private readonly Random random = new();

    public PasswordGenerator(string allowedCharacters)
    {
        AllowedCharacters = allowedCharacters;
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