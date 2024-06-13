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
            int rowChange = cord.Row - row;
            int columnChange = cord.Column - column;

            if (Math.Abs(rowChange) <= 1 && columnChange == 0) 
            { 
                Console.WriteLine("These rows are adjacent");
            }
            if (Math.Abs(columnChange) <= 1 && rowChange == 0) 
            {
                Console.WriteLine("These columns are adjacent"); 
            }
            else
            {
                Console.WriteLine("Nothing adjacent");
            }
            
        }
    }
}
