using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40TicTacToe
{
    public class Board
    {
        private readonly Cell[,] _board = new Cell[3,3];

        public Cell ContentsOf(int row, int column) => _board[row, column];
        public bool IsEmpty(int row, int column) => _board[row, column] == Cell.Empty;
        public void FillCell(int row, int column, Cell symbol) => _board[row, column] = symbol;
    }
}
