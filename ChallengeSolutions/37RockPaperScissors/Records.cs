using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37RockPaperScissors
{
    public class Records
    {
        public static int Player1Score = 0;
        public static int Player2Score = 0;
        public static int DrawCount = 0;
        public static int RoundNumber = 1;

        public static void DisplayInfo()
        {
            Console.WriteLine($"Player 1 total wins: {Player1Score} " + $"   Player 2 total wins: {Player2Score} " + $"   Draws: {DrawCount} ");
            Console.WriteLine($"Round Number: {RoundNumber} ");
            Console.WriteLine("--------------------------------------------------------------------------------------------------------");
        } 
    }
}
