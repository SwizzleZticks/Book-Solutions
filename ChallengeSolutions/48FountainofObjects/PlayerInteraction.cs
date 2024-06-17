using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48FountainofObjects
{
    public interface IPlayerInteraction
    {
        public void Interact(FountainOfObjectsGame game);
    }

    public class EnableFountain : IPlayerInteraction
    {
        public void Interact(FountainOfObjectsGame game)
        {

        }
    }
    public class ExitCave : IPlayerInteraction
    {
        public void Interact(FountainOfObjectsGame game)
        {
            Console.WriteLine("");
        }
    }
}
