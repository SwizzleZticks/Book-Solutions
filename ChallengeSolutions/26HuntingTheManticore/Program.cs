
using System.Runtime.InteropServices.JavaScript;

int round = 1;
int cityHealth = 15;
int manticoreHealth = 10;
int cannonDamage = 1;
bool manticoreIsAlive = true;
bool cityIsAlive = true;
bool gameOver = false;

int manticoreLocation = ManticorePlacement(0, 100);

while (!gameOver)
{
    cannonDamage = ManticoreCannonDamage(round, cannonDamage);
    PlayerInformation(cityHealth, manticoreHealth, round, cannonDamage);
    int cannonShot = Player2Range("Enter desired cannon range: ");

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

int ManticoreCannonDamage (int round, int cannonDamage)
{
        if(round % 5 == 0 && round % 3 == 0)
        {
            cannonDamage = 10;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            return cannonDamage;
        }
        else if (round % 5 == 0)
        {
            cannonDamage = 5;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            return cannonDamage;
        }
        else if (round % 3 == 0)
        {
            cannonDamage = 3;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            return cannonDamage;
        }
        else
        {
            cannonDamage = 1;
            Console.ResetColor();
            return cannonDamage;
        }
}

void PlayerInformation(int cityHealth, int manticoreHealth, int round, int cannonDamage)
{
    Console.WriteLine($"STATUS: Round: {round}" + $"  City: {cityHealth}/15" + $"  Manticore: {manticoreHealth}");
    Console.WriteLine($"The cannon is expected to deal {cannonDamage} damage this round.");
}

int ManticorePlacement(int minRange, int maxRange)
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