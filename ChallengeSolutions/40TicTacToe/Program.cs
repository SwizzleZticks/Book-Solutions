namespace _40TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player(Cell.X);
            Player player2 = new Player(Cell.O);

            Board board = new Board();
            BoardRenderer render = new BoardRenderer();

            render.DrawBoard(board);
        }
    }

    public enum Cell
    {
        Empty,
        X,
        O
    }
}
