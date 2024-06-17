using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48FountainofObjects
{
    public interface IPlayerInteraction
    {
        public void Interact(FountainofObjectsGame game);
    }

    public class EnableFountain : IPlayerInteraction
    {
        public void Interact(FountainofObjectsGame game)
        {
            game.FountainState = FountainState.On;
            Console.Write("You hear the rushing waters from the Fountain of Objects. It has been reactivated!");
        }
    }
    public class ExitCave : IPlayerInteraction
    {
        public void Interact(FountainofObjectsGame game)
        {
            Console.WriteLine("");
        }
    }
}
