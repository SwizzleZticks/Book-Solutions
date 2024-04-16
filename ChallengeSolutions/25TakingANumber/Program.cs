int input = AskForNumberInRange("User 1, Enter a number between 0 and 100: ", 0, 100);

Console.Clear();

while (true)
{
    int user2Input = AskForNumber("User 2, enter a number: ");

    if(user2Input == input)
    {
        break;
    }

}

Console.WriteLine("You are correct");

int AskForNumber(string text)
{
    Console.WriteLine(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int AskForNumberInRange (string text, int min, int max)
{
   while (true)
    {
        int number = AskForNumber(text);

        if (number >= min && number <= max)
        {
            return number;
        }
    }
}
