using System.Windows;

namespace _38FifteenPuzzle
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            
            int[][] matrix = new int[4][];
            Player player = new Player();
            bool isComplete = false;

            Game.Init(matrix);
            Game.InitializeValues(matrix);
            
            while (isComplete == false)
            {
                Console.WriteLine($"Total moves: {player.MoveCount}");
                Game.PrintBoard(matrix);

                int userInput = Movement.CheckKey();
                player.MoveCount++;


                switch (userInput)
                {
                    case 1:
                        Movement.MoveZeroUp(matrix, player.X, player.Y);
                        break;
                    case 2:
                        Movement.MoveZeroDown(matrix, player.X, player.Y);
                        break;
                    case 3:
                        Movement.MoveZeroRight(matrix, player.X, player.Y);
                        break;
                    case 4:
                        Movement.MoveZeroLeft(matrix, player.X, player.Y);
                        break;
                }

                Console.Clear();
                isComplete = Game.BoardCompleteCheck(matrix);
            }
        }
    }
}
