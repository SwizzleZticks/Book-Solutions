namespace _57TheSieve
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
                1 => new Sieve(IsEven),
                2 => new Sieve(IsPositive),
                3 => new Sieve(IsMultipleOfTen)

            };

            while (true)
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Filter selection result {sieve.IsGood(number)}.");
            }
        }
        static bool IsEven(int number) => number % 2 == 0;
        static bool IsPositive(int number) => number > 0;
        static bool IsMultipleOfTen(int number) => number % 10 == 0;

    }
}
