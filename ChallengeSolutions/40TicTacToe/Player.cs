using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40TicTacToe
{
    public class Player
    {
        public Cell Symbol { get; }

        public Player(Cell symbol)
        {
            Symbol = symbol;
        }
    }
}
