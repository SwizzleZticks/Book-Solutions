
namespace _48FountainofObjects
{
    public class Player
    {
        public Location Location { get; set; }
        public bool IsAlive { get; set; } = true;
        public Player(Location start)
        {
            Location = start;
        }

    }
}