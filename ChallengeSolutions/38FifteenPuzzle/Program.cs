
namespace _38FifteenPuzzle
{
    internal class Program
    {     
        static void Main(string[] args)
        {
            int[][] matrix = new int[4][];
            Player player = new Player();

            Game.Init(matrix);
            Game.InitializeValues(matrix);

            Game.PrintBoard(matrix);

            int userInput = Game.GetUserChoice();

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

            Game.PrintBoard(matrix);

        }
    }
}
