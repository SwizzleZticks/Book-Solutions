

namespace _37RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player firstPlayer = new Player();
            Player secondPlayer = new Player();

            bool gameOn = true;

            while (gameOn)
            {
                Records.DisplayInfo();

                firstPlayer.GetChoice("Player 1 choose rock, paper, or scissors: ");
                secondPlayer.GetChoice("Player 2 choose rock, paper, or scissors: ");

                firstPlayer.isWinner = RPSRound.GetWinner(firstPlayer.PlayerChoice,secondPlayer.PlayerChoice);

                if (firstPlayer.PlayerChoice != secondPlayer.PlayerChoice)
                {
                    if (firstPlayer.isWinner == true)
                    {
                        Records.Player1Score++;
                        Console.WriteLine($"Player 1 wins with {firstPlayer.PlayerChoice}!");
                        Console.WriteLine();
                    }
                    else if (firstPlayer.isWinner == false)
                    {
                        Records.Player2Score++;
                        Console.WriteLine($"Players 2 wins with {secondPlayer.PlayerChoice}!");
                        Console.WriteLine();
                    }
                }

                else
                {
                    Console.WriteLine("DRAW noone wins!");
                    Console.WriteLine();
                    Records.DrawCount++;
                }  
                
                Records.RoundNumber++;

            }
        }
    }
}
