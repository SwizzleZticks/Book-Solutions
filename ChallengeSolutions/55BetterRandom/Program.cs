namespace _55BetterRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine(rnd.NextDouble(100));
            Console.WriteLine(rnd.NextString("this","is","a","test"));
            Console.WriteLine(rnd.CoinFlip(0.25));

        }
    }
}
