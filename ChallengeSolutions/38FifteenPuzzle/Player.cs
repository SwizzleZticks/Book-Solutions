using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38FifteenPuzzle
{
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int MoveCount { get; set; }

        public Player()
        {
            X = 0;
            Y = 0;
            MoveCount = 0;
        }

        public static void FindZeroCoordinates(int[][] matrix, out int _x, out int _y)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        _x = i;
                        _y = j;

                        return;
                    }
                }
            }
            _x = -1;
            _y = -1;
        }
    }
}
