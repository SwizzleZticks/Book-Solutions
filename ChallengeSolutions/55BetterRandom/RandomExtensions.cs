using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _55BetterRandom
{
    public static class RandomExtensions
    {
        public static double NextDouble(this Random random, double max) => random.NextDouble() * max;
        public static string NextString(this Random random, params string[] options) => options[random.Next(options.Length)];
        public static bool CoinFlip(this Random random, double headFreq = 0.5) => random.Next() < headFreq;
    }
}
