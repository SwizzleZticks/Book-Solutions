using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _38FifteenPuzzle
{
    public class Game
    {
        private static Random rng = new Random();
        private static List<int> numberPool = (new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 }).ToList();

        public static void Init(int[][] matrix)
        {
            matrix[0] = new int[4];
            matrix[1] = new int[4];
            matrix[2] = new int[4];
            matrix[3] = new int[4];
        }

        public static void InitializeValues(int[][] matrix)
        {
            for(int i = 0; i < 4 ; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix[i][j] = GetDeleteRandom(numberPool);
                }
            }
        }

        public static void PrintBoard(int[][] matrix)
        {
            Console.WriteLine("+----+----+----+----+");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                Console.Write("| {0,2} " , matrix[j][i]);
                }
                Console.WriteLine("|");
                Console.WriteLine("+----+----+----+----+");
            }
        }

        public static int GetUserChoice()
        {
            int userInput = 0;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the direction you want to move.");
                Console.WriteLine("1-Up,2-Down,3-Right,4-Left");
                Console.WriteLine();

                if (!Int32.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Please enter an actual number.");
                }

                if (userInput < 1 || userInput > 4)
                {
                    Console.WriteLine("Please enter a number between 1 and 4."); 
                }
                else 
                {
                    break;
                }
                    
            }

            return userInput;
        }

        private static int GetDeleteRandom(List<int> pool)
        {
            int accessIndex = rng.Next(0, pool.Count);//gets random index from an always shortening list
            int result = pool[accessIndex]; // getting the value at the random index
            pool.RemoveAt(accessIndex);  // removes value at the random index

            return result;
        }
    }
}
