using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48FountainofObjects
{
    public class GameDisplay
    {
        public LocationState[,] map = new LocationState[4,4];

        public void GameStatus(Player player, GameDisplay map)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.Write($"You are in the room at (Row={ player.Row }, Column={ player.Column }).");
            if(player.Row == 0 &&  player.Column == 2)
            {
                Console.Write("You hear water dripping in this room. The Fountain of Objects is here");
                Console.Write("What do you want to do, enable fountain or move?");
            }
            if (player.Row == 0 & player.Column == 0)
            {
                Console.Write("You see light coming from the cavern entrance.");
                Console.Write("What do you want to do, move or exit?: ");
                string? userInput = Console.ReadLine();
                if (!String.IsNullOrEmpty(userInput) && userInput.ToLower() == "move") 
                { 
                    // need to loop until player uses arrow keys to move
                    Console.Write("Use arrow keys to move");
                    ConsoleKeyInfo keyPress = Console.ReadKey();

                    switch(keyPress.Key)
                    {
                        case ConsoleKey.UpArrow:
                            new NorthCommand();
                        case ConsoleKey.DownArrow:
                            new SouthCommand();
                        case ConsoleKey.LeftArrow:
                            new WestCommand();
                        case ConsoleKey.RightArrow:
                            new WestCommand();
                    }
                    
                }
                if (!String.IsNullOrEmpty(userInput) && userInput.ToLower() == "exit")
                {
                    //need to check to see if fountain is on or not, also need to loop till user enters exit
                }

            }
            Console.Write("What do you want to do?(Use arrow keys to move)");

        }
    }
}
