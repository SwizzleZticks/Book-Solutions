using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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

        public Location PickLocation(Board board)
        {
            while (true) 
            {
                Console.Write("What Location do you want to play in?");
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();

                Location choice = key switch
                {
                    ConsoleKey.NumPad7 => new Location(0, 0),
                    ConsoleKey.NumPad8 => new Location(0, 1),
                    ConsoleKey.NumPad9 => new Location(0, 2),
                    ConsoleKey.NumPad4 => new Location(1, 0),
                    ConsoleKey.NumPad5 => new Location(1, 1),
                    ConsoleKey.NumPad6 => new Location(1, 2),
                    ConsoleKey.NumPad1 => new Location(2, 0),
                    ConsoleKey.NumPad2 => new Location(2, 1),
                    ConsoleKey.NumPad3 => new Location(2, 2),
                    _ => new Location(0, 0)
                };

                if(board.IsEmpty(choice.Row,choice.Column))
                {
                    return choice;
                }
                else
                {
                    Console.WriteLine("That location is already taken.");
                }
            }
        }
    }
}
