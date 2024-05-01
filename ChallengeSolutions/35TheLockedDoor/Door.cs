using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace TheLockedDoor
{
    public class Door
    {
        private int _passCode;
        public DoorState CurrentState { get; set; }

        public Door(int passCode, DoorState currentState)
        {
            _passCode = passCode;
            this.CurrentState = currentState;
        }

        public static Door SetPassCode()
        {
            Console.Write("Please enter a 4 digit passcode: ");
            string? passCode = Console.ReadLine();

            bool isValidPasscode = passCode?.Length == 4;

            while (!isValidPasscode)
            {
                Console.Clear();
                Console.Write("Please enter a 4 digit passcode: ");
                passCode = Console.ReadLine();
            }
            Console.Clear();
            return new Door(Convert.ToInt32(passCode), DoorState.Locked);
        }
        public void Unlock(int guess)
        {
            if (CurrentState == DoorState.Locked && guess == _passCode)
            {
                CurrentState = DoorState.Closed;
            }
        }

        public void Open()
        {
            if (CurrentState == DoorState.Locked) 
            {
                Console.WriteLine("This door is still locked please unlock first.");
                CurrentState = DoorState.Locked;
            }
            else if (CurrentState == DoorState.Opened) 
            {
                Console.WriteLine("This door is already opened please choose another action.");
                CurrentState = DoorState.Opened;
            }
            else
            {
                CurrentState = DoorState.Opened;
            }
        }
        public void Lock()
        {
            if(CurrentState  == DoorState.Locked)
            {
                Console.WriteLine("The door is already locked, please choose another action.");
                CurrentState = DoorState.Locked;
            }
            else if(CurrentState == DoorState.Opened)
            {
                Console.WriteLine("Please close the door before locking.");
                CurrentState = DoorState.Opened;
            }
            else
            {
                CurrentState = DoorState.Locked;
            }
        }
        public void Close()
        {
            if(CurrentState == DoorState.Locked)
            {
                Console.WriteLine("You must unlock the door first before doing anything.");
                CurrentState = DoorState.Locked;
            }
            else if(CurrentState == DoorState.Closed) 
            {
                Console.WriteLine("The door is already closed.");
                CurrentState = DoorState.Closed;
            }
            else
            {
                CurrentState = DoorState.Closed;
            }
        }

        public int CodeChange(int currentCode,int newPassCode)
        {
            if (currentCode == newPassCode)
            {
                newPassCode = currentCode;
                CurrentState = DoorState.Locked;
            }
            return newPassCode;
        }

        public int GetInt(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}