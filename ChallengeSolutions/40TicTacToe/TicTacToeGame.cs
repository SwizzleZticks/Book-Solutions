using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40TicTacToe
{
    public class TicTacToeGame
    {
        public void Run()
        {
            Player player1 = new Player(Cell.X);
            Player player2 = new Player(Cell.O);

            Board board = new Board();
            BoardRenderer render = new BoardRenderer();

            Player currentPlayer = player1;
            int turnNumber = 0;

            while (turnNumber < 9)
            {
                render.DrawBoard(board);
                Console.WriteLine($"It is {currentPlayer.Symbol}'s turns");

                Location loc = currentPlayer.PickLocation(board);
                board.FillCell(loc.Row, loc.Column, currentPlayer.Symbol);

                if (HasWon(board, Cell.X))
                {
                    Console.Clear();
                    render.DrawBoard(board);
                    Console.WriteLine("X won!");
                    return;
                }
                else if (HasWon(board, Cell.O))
                {
                    Console.Clear();
                    render.DrawBoard(board);
                    Console.WriteLine("O won!");
                }

                currentPlayer = currentPlayer == player1 ? player2 : player1;
                turnNumber++;
                Console.Clear();
            }

            render.DrawBoard(board);
            Console.WriteLine("Draw!");
        }

        private bool HasWon(Board board, Cell symbol)
        {
            //check rows
            if (board.ContentsOf(0, 0) == symbol && board.ContentsOf(0, 1) == symbol && board.ContentsOf(0, 2) == symbol) return true;
            if (board.ContentsOf(1, 0) == symbol && board.ContentsOf(1, 1) == symbol && board.ContentsOf(1, 2) == symbol) return true;
            if (board.ContentsOf(2, 0) == symbol && board.ContentsOf(2, 1) == symbol && board.ContentsOf(2, 2) == symbol) return true;

            //check columns
            if (board.ContentsOf(0, 0) == symbol && board.ContentsOf(1, 0) == symbol && board.ContentsOf(2, 0) == symbol) return true;
            if (board.ContentsOf(0, 1) == symbol && board.ContentsOf(1, 1) == symbol && board.ContentsOf(2, 1) == symbol) return true;
            if (board.ContentsOf(0, 2) == symbol && board.ContentsOf(1, 2) == symbol && board.ContentsOf(2, 2) == symbol) return true;

            //check diags
            if (board.ContentsOf(0, 0) == symbol && board.ContentsOf(1, 1) == symbol && board.ContentsOf(2, 2) == symbol) return true;
            if (board.ContentsOf(2, 0) == symbol && board.ContentsOf(1, 1) == symbol && board.ContentsOf(0, 2) == symbol) return true;

            return false;
        }
    }
}
