
namespace _48FountainofObjects
{
    public class Player
    {
        public Location Location { get; set; }
        public bool IsAlive { get; set; } = true;
        public string CauseOfDeath { get; private set; } = "";
        public Player(Location start)
        {
            Location = start;
        }
        public void Kill(string cause)
        {
            IsAlive = false;
            CauseOfDeath = cause;
        }
    }
}