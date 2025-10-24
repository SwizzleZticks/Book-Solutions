namespace _59TheLambdaSieve
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pick a filter:");
            Console.WriteLine("1: Check even number");
            Console.WriteLine("2: Check is positive number");
            Console.WriteLine("3: Check is multiple of 10");

            int userInput = Convert.ToInt32(Console.ReadLine());

            Sieve sieve = userInput switch
            {
                1 => new Sieve(x => x % 2 == 0),
                2 => new Sieve(x => x > 0),
                3 => new Sieve(x => x % 10 == 0)

            };

            while (true)
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Filter selection result {sieve.IsGood(number)}.");
            }
        }
    }
}
