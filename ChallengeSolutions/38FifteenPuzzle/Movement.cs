using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38FifteenPuzzle
{
    public class Movement
    {
        private static bool Move(int[][] matrix, int dirX, int dirY)
        {
            int zeroX = -1;
            int zeroY = -1;

            int targetX = -1;
            int targetY = -1;

            Player.FindZeroCoordinates(matrix, out zeroX, out zeroY);

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

        public static int CheckKey()
        {
            Console.WriteLine("Please use the arrow keys to move the 0 around");

            ConsoleKeyInfo keyPress = Console.ReadKey();

            switch (keyPress.Key)
            {
            case ConsoleKey.UpArrow:
                return 1;
            case ConsoleKey.DownArrow:
                return 2;
            case ConsoleKey.RightArrow:
                return 3;
            case ConsoleKey.LeftArrow:
                return 4;
            }

            return 0;
        }
    }
}
