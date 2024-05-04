using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37RockPaperScissors
{
    public class Player
    {
        public HandChoice PlayerChoice { get; set; }
        public bool isWinner {  get; set; }

        public Player()
        {
            PlayerChoice = HandChoice.None;
            isWinner = false;
        }

        public void GetChoice(string message) 
        {
            Console.Write(message);
            string? userInput = Console.ReadLine()?.ToUpper();

            switch(userInput) 
            {
                case "ROCK":
                    PlayerChoice = HandChoice.Rock;
                    break;
                case "PAPER":
                    PlayerChoice = HandChoice.Paper;
                    break;
                case "SCISSORS":
                    PlayerChoice = HandChoice.Scissors;
                    break;
                default:
                    Console.WriteLine("That is not a valid choice");
                    break;
            }
        }
    }
}
