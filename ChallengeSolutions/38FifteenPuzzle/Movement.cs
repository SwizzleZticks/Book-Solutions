using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38FifteenPuzzle
{
    public class Movement
    {
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

        private static bool Move(int[][] matrix, int dirX, int dirY)
        {
            int zeroX = -1;
            int zeroY = -1;

            int targetX = -1;
            int targetY = -1;

            FindZeroCoordinates(matrix, out zeroX, out zeroY);

            if (zeroX == -1 || zeroY == -1)
            {
                return false;
            }

            if (dirX == 1)
            {
                targetX = zeroX + 1;
                targetY = zeroY;
            }
            else if (dirX == -1)
            {
                targetX = zeroX - 1;
                targetY = zeroY;
            }
            else if (dirY == 1)
            {
                targetX = zeroX;
                targetY = zeroY + 1;
            }
            else if (dirY == -1)
            {
                targetX = zeroX;
                targetY = zeroY - 1;
            }
            else
            {
                Console.WriteLine("Its only 1 or -1");
                return false;
            }

            if ((targetX < 0 || targetX > 3) || (targetY < 0 || targetY > 3))
            {
                Console.WriteLine("Invalid Move");
                return false;
            }

            matrix[zeroX][zeroY] = matrix[targetX][targetY];
            matrix[targetX][targetY] = 0;

            return true;
        }
        public static bool MoveZeroUp(int[][] matrix,int x, int y)
        {
            return Move(matrix,0, -1);
        }

        public static bool MoveZeroDown(int[][] matrix,int x, int y)
        {
            return Move(matrix,0, 1);
        }

        public static bool MoveZeroRight(int[][] matrix, int x, int y)
        {
            return Move(matrix, 1, 0);
        }

        public static bool MoveZeroLeft(int[][] matrix,int x, int y)
        {
            return Move(matrix, -1, 0);
        }
    }
}
