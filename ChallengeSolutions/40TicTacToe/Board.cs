using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40TicTacToe
{
    public class Board
    {
        private readonly Cell[,] GameBoard = new Cell[3,3];

        public Cell ContentsOf(int row, int column) => GameBoard[row, column];
    }
}
