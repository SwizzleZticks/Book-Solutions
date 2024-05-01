namespace TheLockedDoor;

public static class Program
{
    public static void Main()
    {
        var currentDoor = Door.SetPassCode();

        while (true)
        {
            Console.Write(
                $"The door is {currentDoor.CurrentState}. What do you want to do? (open, close, lock, unlock, change code) "
            );
            var command = Console.ReadLine(); // Case-sensitive for Enum, Title Case.
            if (!Enum.TryParse<Action>(command, out var action)) // Get action enum instead
            {
                Console.Clear();
                continue;
            }

            currentDoor.ChangeState(action);
        }
    }
}

public class Door
{
    private int _passCode; // Not used outside of class.
    public DoorState CurrentState { get; private set; } // Setter access is only used in class.

    private Door(int passCode, DoorState currentState) // Constructor is only used within static method.
    {
        _passCode = passCode;
        CurrentState = currentState;
    }

    public static Door SetPassCode()
    {
        string? rawPass = null;
        while (rawPass?.Length is not 4)
        {
            Console.Clear();
            Console.Write("Please enter a 4 digit passcode: ");
            rawPass = Console.ReadLine();
        }

        Console.Clear();
        return new Door(Convert.ToInt32(rawPass), DoorState.Locked);
    }

    public void ChangeState(Action command)
    {
        switch (command)
        {
            case Action.Open:
                if (CurrentState is DoorState.Locked) // We need to retain the locked state
                {
                    Console.WriteLine("The door is locked.");
                    return;
                }

                CurrentState = DoorState.Opened;
                Console.Clear(); // These clears can probably be moved
                break;
            case Action.Close:
                CurrentState =
                    CurrentState is DoorState.Locked ? DoorState.Locked : DoorState.Closed; // We need to retain the locked state
                Console.Clear();
                break;
            case Action.Lock:
                CurrentState = DoorState.Locked;
                Console.Clear();
                break;
            case Action.Unlock:
                var guess = ConvertToInt("What is the passcode? ");
                Unlock(guess); // The context is already itself, don't need to pass itself to itself.
                CurrentState = DoorState.Closed;
                Console.Clear();
                break;
            case Action.ChangeCode:
                // We don't need to ask for the new password until we prove old correct.
                var oldCode = ConvertToInt("What is the current passcode: ");
                if (!IsCodeCorrect(oldCode)) // The context is already itself, don't need to pass itself to itself.
                {
                    Console.WriteLine("The passcode was not correct.");
                    return;
                }

                var newCode = ConvertToInt("What do you want to change it to? ");
                _passCode = newCode; // The context is already itself, don't need to pass itself to itself.
                Console.Clear();
                break;
        }
    }

    private void Unlock(int passCode) // Not used outside of class.
    {
        if (CurrentState == DoorState.Locked && passCode == _passCode)
        {
            CurrentState = DoorState.Locked;
        }
    }

    private bool IsCodeCorrect(int oldPassCode) // Not used outside of class. Renamed
    {
        return _passCode == oldPassCode;
    }

    private static int ConvertToInt(string text) // Can be private static, renamed.
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }
}

public enum DoorState
{
    Locked, // locked with passcode
    Closed, // can be locked, or opened
    Opened // can be closed
}

public enum Action
{
    Open,
    Close,
    Lock,
    Unlock,
    ChangeCode
}
