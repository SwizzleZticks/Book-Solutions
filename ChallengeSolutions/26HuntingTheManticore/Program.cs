

int round = 1;
int cityHealth = 15;
int manticoreHealth = 10;
int cannonDamage = 1;
bool gameOver = false;
bool manticoreIsAlive = true;

int manticoreLocation = PlaceManticore();

while (!gameOver)
{
    cannonDamage = CalculateManticoreCannonDamage();
    DisplayPlayerInformation();
    int cannonShot = Player2Range("Enter desired cannon range: ");
    Console.WriteLine(HitCheck(manticoreLocation, cannonShot));

    if (cannonShot == manticoreLocation)
    {
        manticoreHealth -= cannonDamage;
        
        Console.WriteLine("-------------------------------");
        if (cityHealth == 0)
        {
            Console.WriteLine("The city of Consolas has fallen!");
            Console.WriteLine("-------------------------------");
            gameOver = true;
        }
        if (manticoreHealth <= 0)
        {
            Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
            Console.WriteLine("-------------------------------");
            gameOver = true;
        }
        if (manticoreIsAlive)
        {
            cityHealth -= 1;
            round += 1;
        }
    }

    else if (cannonShot != manticoreLocation)
    {
        if (cityHealth == 0)
        {
            Console.WriteLine("The city of Consolas has fallen!");
            Console.WriteLine("-------------------------------");
            gameOver = true;
        }
        if (manticoreHealth <= 0)
        {
            Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
            Console.WriteLine("-------------------------------");
            gameOver = true;
        }
        if (manticoreIsAlive)
        {
            cityHealth -= 1;
            round += 1;
        }
    }
}

string HitCheck(int manticoreLocation, int cannonShot)
{
       
    if (cannonShot == manticoreLocation)
    {
        return "That round was a DIRECT HIT!";
    }
    else if (cannonShot > manticoreLocation)
    {
        return "That round OVERSHOT the target.";
    }
    else
    {
        return "That round FELL SHORT of the target.";
    }
}

int Player2Range(string message)
{
    while (true)
    {
        Console.Write(message);
        int userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput > 0 && userInput < 100)
        {
            return userInput; 
        }
        else if (userInput < 0 || userInput > 100)
        {
            Console.WriteLine("Please enter a range within 0 and 100.");
        }
    }
}

int CalculateManticoreCannonDamage ()
{
        if(round % 5 == 0 && round % 3 == 0)
        {
            cannonDamage = 10;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else if (round % 5 == 0)
        {
            cannonDamage = 5;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else if (round % 3 == 0)
        {
            cannonDamage = 3;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

        }
        else
        {
            cannonDamage = 1;
            Console.ResetColor();
        }
        return cannonDamage;
}

void DisplayPlayerInformation()
{
    Console.WriteLine($"STATUS: Round: {round}" + $"  City: {cityHealth}/15" + $"  Manticore: {manticoreHealth}");
    Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round.");
}

int PlaceManticore()
{ 
    while (true)
    {
        Console.Write("Player 1, how far away from the city do you want to station the manticore? ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        if (userInput > 0 && userInput <= 100)
        {
            Console.Clear();
            return userInput;        
        }
    }
}