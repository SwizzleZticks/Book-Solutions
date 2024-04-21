

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
            cityHealth--;
            round++;
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
            cityHealth--;
            round++;
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
            Console.WriteLine("Please enter a range within 0 and 100.");
    }
}

int CalculateManticoreCannonDamage ()
{
    bool isDivisibleBy5 = round % 5 == 0;
    bool isDivisibleBy3 = round % 3 == 0;

        if(isDivisibleBy5 && isDivisibleBy3)
        {
            cannonDamage = 10;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else if (isDivisibleBy5)
        {
            cannonDamage = 5;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        else if (isDivisibleBy3)
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