// Make a variable whose type is this new enumeration
ChestState currentState = ChestState.Locked;

//forever loop asking for next command
while (true)
{
    // receive input to change current state of box.
    string input = UserInput();
    // change box state
    currentState = CheckState(input);
}

//---------------------------------------METHODS----------------------------------------//

string UserInput () //receive input from user and return that for be evaluated by the a method to check the state of the box
{
    while (true)
    {
        Console.WriteLine($"The current state of the box is {currentState}. What would you like to do?");
        string userInput = Console.ReadLine();

        if (userInput != null)
        {
            return userInput;
        }
    }
}

ChestState CheckState (string userInput) //checks the user command to change box state based on input
{
    if (currentState == ChestState.Locked && userInput.ToLower() == "unlock")
    {
        currentState = ChestState.Closed;
    }

    if (currentState == ChestState.Closed && userInput.ToLower() == "open")
    {
        currentState = ChestState.Opened;
    }

    if (currentState == ChestState.Opened && userInput.ToLower() == "close")
    {
        currentState = ChestState.Closed;
    }
    if (currentState == ChestState.Closed && userInput.ToLower() == "lock")
    {
        currentState = ChestState.Locked;
    }

    return currentState;

}

// define an enum for the chest state (this lives at the end of the main method)
enum ChestState { Locked, Opened, Closed }
