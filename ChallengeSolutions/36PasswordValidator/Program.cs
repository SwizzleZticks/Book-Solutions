using System.Reflection.Metadata;

namespace _36PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PasswordValidator validator = new PasswordValidator();

            while (true)
            {
                Console.WriteLine("Please enter a password.");
                Console.WriteLine("Password must contain 1 upper, 1 lower, and 1 number(no T, or & allowed)");
                string? userInput = Console.ReadLine();


                if(userInput == null) 
                {
                    break;
                }

                if (validator.IsValid(userInput))
                {
                    Console.WriteLine("That password is valid.");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("That password is not valid.");
                    Console.WriteLine();
                }
            }
        }
    }
}
