
namespace _38FifteenPuzzle
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int[][] matrix = new int[4][];

            Game.Init(matrix);
            Game.InitializeValues(matrix);

            Game.PrintBoard(matrix);

            Console.WriteLine();
            Console.WriteLine("Please enter the direction you want to move.");
            Console.WriteLine("1-Up,2-Down,3-Right,4-Left");
            Console.WriteLine();

            int userInput;
            if(!Int32.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Please enter an actual number.");
                return;
            }

            if(userInput < 1 || userInput > 4)
            {
                Console.WriteLine("Please enter a number between 1 and 4.");
                return;
            }

            switch (userInput)
            {
                case 1:
                    Movement.MoveZeroUp(matrix, x, y);
                    break;
                case 2:
                    Movement.MoveZeroDown(matrix, x, y);
                    break;
                case 3:
                    Movement.MoveZeroRight(matrix, x, y);
                    break;
                case 4:
                    Movement.MoveZeroLeft(matrix, x, y);
                    break;
            }

            Game.PrintBoard(matrix);

        }
    }
}
