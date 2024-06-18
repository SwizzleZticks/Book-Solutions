using System.Security.Cryptography.X509Certificates;

namespace _48FountainofObjects
{
    public record Location(int Row, int Column);
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
        FountainOfObjectsGame CreateGame()
        {
            Map map = new Map(4, 4);
            Location start = new Location(0, 0);
            map.SetRoomType(start, RoomType.Entrance);
            map.SetRoomType(new Location(0, 2), RoomType.Fountain);

            return new FountainOfObjectsGame(new Player(start), map);
        }
        public void Run()
        {
            GameStatus();
        }
        private void GameStatus()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            Console.Write($"You are in the room at (Row={ Player.Location.Row }, Column={ Player.Location.Column }).");
        }

        public RoomType CurrentRoom => Map.GetRoomTypeAtLocation(Player.Location);

        public bool HasWon => CurrentRoom == RoomType.Entrance && IsFountainOn;
    }
}
