using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace TheLockedDoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Door currentDoor = Door.SetPassCode();

            while (true)
            {
                Console.Write($"The door is {currentDoor.CurrentState}. What do you want to do?(open, close, lock, unlock, change code)");
                string? command = Console.ReadLine().ToUpper();

                currentDoor.ChangeState(command, currentDoor);
            }
        }
    }
}
