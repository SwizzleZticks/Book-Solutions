
namespace _48FountainofObjects
{
    public class FountainofObjectsGame
    {
        public FountainState FountainState { get; set; } = FountainState.Off;
        public Location Entrance {  get; set; } = new Location(0,0);
        public Location FountainLocation { get; set; } = new Location(0, 2);
        public void Run()
        {
            GameDisplay map = new GameDisplay();
            Player player = new Player();


        }
    }
}
