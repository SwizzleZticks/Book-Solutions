﻿using System;
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
            for (int i = 0; i < 4; i++)
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
                    Console.Write("| {0,2} ", matrix[j][i]);
                }
                Console.WriteLine("|");
                Console.WriteLine("+----+----+----+----+");
            }
        }
        private static int GetDeleteRandom(List<int> pool)
        {
            int accessIndex = rng.Next(0, pool.Count);//gets random index from an always shortening list
            int result = pool[accessIndex]; // getting the value at the random index
            pool.RemoveAt(accessIndex);  // removes value at the random index

            return result;
        }

        public static bool BoardCompleteCheck(int[][] matrix)
        {
            bool isComplete = false;

            if (matrix[0][0] == 1 && matrix[0][1] == 2 && matrix[0][2] == 3 && matrix[0][3] == 4)
            {
                if (matrix[1][0] == 5 && matrix[1][1] == 6 && matrix[1][2] == 7 && matrix[1][3] == 8)
                {
                    if (matrix[2][0] == 9 && matrix[2][1] == 10 && matrix[2][2] == 11 && matrix[2][3] == 12)
                    {
                        if (matrix[3][0] == 13 && matrix[3][1] == 14 && matrix[3][2] == 15)
                        {
                            isComplete = true;
                        }
                    }
                }
            }
            return isComplete;
        }
    }
}

