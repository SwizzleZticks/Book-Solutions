using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37RockPaperScissors
{
    public class RPSRound
    {
        public static bool GetWinner(HandChoice player1Choice, HandChoice player2Choice)
        {
            bool oneIsWinner = player1Choice == HandChoice.Rock && player2Choice == HandChoice.Scissors || 
                player1Choice == HandChoice.Paper && player2Choice == HandChoice.Rock || 
                player1Choice == HandChoice.Scissors && player2Choice == HandChoice.Paper;

            bool twoIsWinner = player2Choice == HandChoice.Rock && player1Choice == HandChoice.Scissors ||
                player2Choice == HandChoice.Paper && player1Choice == HandChoice.Rock ||
                player2Choice == HandChoice.Scissors && player1Choice == HandChoice.Paper;


            if (oneIsWinner)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
