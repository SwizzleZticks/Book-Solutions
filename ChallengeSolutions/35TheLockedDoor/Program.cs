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
                string? command = Console.ReadLine()?.ToUpper();

                switch (command)
                {
                    case "OPEN":
                        currentDoor.Open();
                        break;
                    case "CLOSE":
                        currentDoor.Close();
                        break;
                    case "LOCK":
                        currentDoor.Lock();
                        break;
                    case "UNLOCK":
                        int guess = currentDoor.GetInt("What is the passcode? ");
                        currentDoor.Unlock(guess);
                        break;
                    case "CHANGE CODE":
                        int currentCode = currentDoor.GetInt("Enter the current password to change the code: ");
                        int newCode = currentDoor.GetInt("What do you want to change it to? ");
                        currentDoor.CodeChange(currentCode,newCode);
                        break;
                }
            }
        }
    }
}