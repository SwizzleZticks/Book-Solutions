using System.Data;
using System.Runtime.CompilerServices;

namespace _45RoomCoordinates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int column = 0;

            while(true)
            {
                row = GetInt("Please enter a row coordinate: ");
                column = GetInt("Please enter a column coordinate: ");

                Coordinate cords = GetValue();
                cords.AdjacentCheck(cords, row, column);
                
            }
        }

        static Coordinate GetValue()
        {
            int row = 0;
            int column = 0;

            row = GetInt("Please another enter a row coordinate: ");
            column = GetInt("Please another enter a column coordinate: ");

            return new Coordinate(row, column);
        }

        static int GetInt(string message)
        {
            int userInput;

            while (true)
            {
                Console.Write(message);
                userInput = int.Parse(Console.ReadLine());

                if(userInput != 0)
                {
                    break;
                }
            }

            Console.Clear();
            return userInput;
        }
    }
}
