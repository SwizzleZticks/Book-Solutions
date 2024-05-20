
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace _39Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] word = ['H', 'E', 'L', 'L', 'O'];
            char[] replace = new char[word.Length];
            char[] incorrect = new char[word.Length];
            int remaining = 5;

            for (int i = 0; i < word.Length; i++)
            {
                replace[i] = '_';
            }

            for (int i = 0; i < word.Length; ++i)
            {
            
            Console.WriteLine("Guess a letter to finish spelling the word.");
            char userInput = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
            Console.Clear();
            Console.Write("Word: ");

                for (int j = 0; j < word.Length; ++j)
                {            
                    if (word[j] == Char.ToUpper(userInput))
                    {
                        replace[j] = word[j];
                    }
                    Console.Write(replace[j]);
                }

                if (word[i] != Char.ToUpper(userInput))
                {
                    if (incorrect[i] == userInput)
                    {
                        continue;
                    }
                    else
                    {
                        incorrect[i] = userInput;
                        remaining--;
                    }
                }
                
                Console.Write($" | Remaining: {remaining} | ");
                Console.Write("Incorrect: ");
                foreach (char c in incorrect)
                {
                    Console.Write(c);
                }
                Console.WriteLine($" | Last Guess: {userInput} | ");
            }
        }
    }
}
