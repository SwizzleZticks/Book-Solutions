namespace _56ExeptisGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> usedNumbers = new List<int>();

            while (true)
            {
                int randomNumber = random.Next(0,10);

                usedNumbers.Add(randomNumber);

                try
                {
                    Console.Write("Enter a number between 0 and 9: ");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    if (usedNumbers.Contains(userInput)) throw new Exception("This number has already been used");
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex);                   
                }
            }           
        }
    }
}
