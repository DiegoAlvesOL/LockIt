namespace LockIt.LockItUi;
using LockIt.LockItCore;
public static class ConsoleUi
{
    public static void Start()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("+===========================+");
            Console.WriteLine("|     WELCOME TO LOCKIT     |");
            Console.WriteLine("+===========================+");
            Console.WriteLine("| 1 - Generate password     |");
            Console.WriteLine("| 0 - To exit the software  |");
            Console.WriteLine("+===========================+");
            
            Console.WriteLine("Enter your choice");

            string selection = Console.ReadLine().Trim();

            if (selection == "0")
            {
                Console.WriteLine("Thank you for using LockIt.");
                break;
            }
            else if (selection == "1")
            {
                Console.WriteLine("What is the length of your password? e.g. 4, password %r4D");
                int lenght = Convert.ToInt32((Console.ReadLine() ?? "").Trim());
            
                PasswordGenerator.GeneratePassword(lenght);
            }
            else
            {
                Console.WriteLine("Option invalid, please try again");
                Console.ReadKey();
            }
        }
    }
    
}