
namespace _39Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] word = ['H', 'E', 'L', 'L', 'O'];
            char[] replace = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                replace[i] = '_';
            }

            for (int i = 0; i < word.Length; ++i)
            {
            
            Console.WriteLine("Guess a letter to finish spelling the word.");
            char? userInput = Convert.ToChar(Console.ReadLine());

                if (word[i] == userInput)
                {
                    replace[i] = word[i];
                }
              
                for (int z = 0; z < word.Length; z++)
                {
                    
                    Console.Write(replace[z]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
