using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48FountainofObjects
{
    public static class ConsoleHelper
    {
        public static void WriteLine(string text, ConsoleColor color) 
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }
        public static void Write(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
        }
    }
}
