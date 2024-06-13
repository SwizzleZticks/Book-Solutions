using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45RoomCoordinates
{
    public readonly struct Coordinate
    {
        public int Row { get; init; }
        public int Column { get; init; }

        public Coordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }
        
        public static void AdjacentCheck(Coordinate cord, int row, int column)
        {

            if(cord.Row - row == -1 || cord.Row - row == 1)
            {
                Console.WriteLine("These row coordinates are adjacent");
            }

            else if(cord.Column - column == -1 || cord.Column - row == 1)
            {
                Console.WriteLine("These column coordinates are adjacent");
            }

            else
            {
                Console.WriteLine("Neither column or row are adjacent");
            }
        }
    }
}
