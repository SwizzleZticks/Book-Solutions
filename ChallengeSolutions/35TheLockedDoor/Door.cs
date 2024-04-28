using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace TheLockedDoor
{
    public class Door
    {
        public int PassCode { get; set; }
        public DoorState CurrentState { get; set; }

        public Door(int passCode, DoorState currentState)
        {
            this.PassCode = passCode;
            this.CurrentState = currentState;
        }

        public static Door SetPassCode()
        {
            Console.Write("Please enter a 4 digit passcode: ");
            int passCode = Convert.ToInt32(Console.ReadLine());

            bool isValidPasscode = passCode > 999 && passCode < 9999;

            while (!isValidPasscode)
            {
                Console.Clear();
                Console.Write("Please enter a 4 digit passcode: ");
                passCode = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            return new Door(passCode, DoorState.Locked);
        }

        public void ChangeState(string command, Door currentDoor)
        {
            switch (command)
            {
                case "OPEN":
                    CurrentState = DoorState.Opened;
                    Console.Clear();
                    break;
                case "CLOSE":
                    CurrentState = DoorState.Closed;
                    Console.Clear();
                    break;
                case "LOCK":
                    CurrentState = DoorState.Locked;
                    Console.Clear();
                    break;
                case "UNLOCK":
                    int guess = currentDoor.GetInt("What is the passcode? ");
                    currentDoor.Unlock(guess);
                    currentDoor.CurrentState = DoorState.Closed;
                    Console.Clear();
                    break;
                case "CHANGE CODE":
                    int oldCode = GetInt("What is the current passcode: ");
                    int newCode = GetInt("What do you want to change it to? ");
                    currentDoor.PassCode = currentDoor.CodeChange(oldCode, newCode);
                    Console.Clear();
                    break;
            }
        }        
        public void Unlock(int passCode)
        {
            if (CurrentState == DoorState.Locked && passCode == PassCode)
            {
                CurrentState = DoorState.Locked;
            }
        }

        public int CodeChange(int oldPassCode, int newPassCode)
        {
            if (oldPassCode == newPassCode)
            {
                PassCode = newPassCode;
            }
            return newPassCode;
        }

        public int GetInt(string text)
        {
            System.Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
