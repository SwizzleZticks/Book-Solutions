namespace _60TheLongGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine()!;
            int playerScore = 0;

            if (File.Exists($"{userName}.txt"))
            {
                playerScore = Convert.ToInt32(File.ReadAllLines($"{userName}.txt")[0]);
            }

            ConsoleKey? pressedKey = ConsoleKey.None;

            while (pressedKey != ConsoleKey.Enter)
            {
                Console.WriteLine($"Current Score: {playerScore}");
                pressedKey = Console.ReadKey().Key;
                Console.Clear();
                playerScore++;
            }

            File.WriteAllText($"{userName}.txt",playerScore.ToString());

            Console.ReadLine();
        }
    }
}
