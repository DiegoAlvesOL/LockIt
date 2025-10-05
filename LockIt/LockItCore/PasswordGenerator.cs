namespace LockIt.LockItCore;

public class PasswordGenerator
{
    public static void GeneratePassword(int length)
    {
        string allChars = CharacterSets.Digits + CharacterSets.LowerCaseLetters + CharacterSets.UpperCaseLetters + CharacterSets.SpecialCharacters;
        
        string password = "";

        Random randomGenerator = new Random();

        for (int currentPosition = 0; currentPosition < length; currentPosition++)
        {
            int randomIndex = randomGenerator.Next(allChars.Length);
            char selectedChar = allChars[randomIndex];
            password = password + selectedChar;
        }
        Console.WriteLine($"Your password is: {password}");
        Console.ReadKey();
    }
}