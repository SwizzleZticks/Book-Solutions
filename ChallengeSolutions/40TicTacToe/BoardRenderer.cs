using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40TicTacToe
{
    public class BoardRenderer
    {
        public void DrawBoard()
        {
            char[,] gameBoard = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' },{ ' ', ' ', ' ' } };

            Console.WriteLine($" {gameBoard[0,0]} | {gameBoard[0,1]} | {gameBoard[0,2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {gameBoard[1,0]} | {gameBoard[1,1]} | {gameBoard[1,2]}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {gameBoard[2,0]} | {gameBoard[2,1]} | {gameBoard[2,2]}");
        }
    }
}
