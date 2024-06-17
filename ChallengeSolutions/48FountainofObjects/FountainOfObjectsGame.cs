namespace _48FountainofObjects
{
    public class FountainOfObjectsGame
    {
        public bool IsOn { get; set; }
        public Location Entrance { get; set; }
        public Location FountainLocation { get; set; }
        public Player Player { get; set; }
        public void Run()
        {
            Map map = new Map(4,4);
            Player player = new Player();


        }
        public void GameStatus(Player player, Map map)
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.Write($"You are in the room at (Row={player.Row}, Column={player.Column}).");
            if (player.Row == 0 && player.Column == 2)
            {
                Console.Write("You hear water dripping in this room. The Fountain of Objects is here");
                Console.Write("What do you want to do, enable fountain or move?");
            }
            if (player.Row == 0 & player.Column == 0)
            {
                Console.Write("You see light coming from the cavern entrance.");
                Console.Write("What do you want to do, move or exit?: ");
                string? userInput = Console.ReadLine();
                if (!String.IsNullOrEmpty(userInput) && userInput.ToLower() == "move")
                {
                    // need to loop until player uses arrow keys to move
                    Console.Write("Use arrow keys to move");
                    ConsoleKeyInfo keyPress = Console.ReadKey();

                    switch (keyPress.Key)
                    {
                        case ConsoleKey.UpArrow:
                            new NorthCommand();
                        case ConsoleKey.DownArrow:
                            new SouthCommand();
                        case ConsoleKey.LeftArrow:
                            new WestCommand();
                        case ConsoleKey.RightArrow:
                            new WestCommand();
                    }

                }
                if (!String.IsNullOrEmpty(userInput) && userInput.ToLower() == "exit")
                {
                    //need to check to see if fountain is on or not, also need to loop till user enters exit
                }

            }
            Console.Write("What do you want to do?(Use arrow keys to move)");

        }
    }
}
public enum RoomType { 
    Normal, 
    Entrance, 
    Fountain, 
    OffTheMap 
}