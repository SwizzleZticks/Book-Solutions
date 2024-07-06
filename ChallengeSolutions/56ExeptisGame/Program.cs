namespace _56ExeptisGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int targetNumber = new Random().Next(10);
                List<int> usedNumbers = new List<int>();

                while (true)
                {
                    bool previouslyGuessed;
                    int userInput;

                    do
                    {
                        Console.Write("Enter a number between 0 and 9: ");
                        userInput = Convert.ToInt32(Console.ReadLine());
                        previouslyGuessed = usedNumbers.Contains(targetNumber);


                        if (previouslyGuessed) Console.WriteLine("That number has been guessed before");
                    } while (previouslyGuessed);


                    if (userInput == targetNumber) throw new Exception();

                    usedNumbers.Add(userInput);

                }
            }
            catch (Exception)
            {
                Console.WriteLine("bad number, you lose.");
            }
        }
    }
}
