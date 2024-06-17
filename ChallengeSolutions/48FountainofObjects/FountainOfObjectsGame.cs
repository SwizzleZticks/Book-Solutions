namespace _48FountainofObjects
{
    public record Location(int Row, int Column);
    public bool HasWon = 
    public class FountainOfObjectsGame
    {
        public Player Player { get; }
        public Map Map { get; }
        public bool IsFountainOn { get; set; }
        public FountainOfObjectsGame(Player player,Map map)
        {
            Player = player;
            Map = map;
        }
        public void Run()
        {
            Map map = new Map(4, 4);
            Location start = new Location(0, 0);
            Location fountain = new Location(0, 2);
            Player player = new Player(start);

            GameStatus();
        }
        private void GameStatus()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.Write($"You are in the room at (Row={ Player.Location.Row }, Column={ Player.Location.Column }).");
        }
    }
}
