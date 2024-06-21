using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48FountainofObjects
{
    public abstract class Monster
    {
        public Location Location { get; set; }

        public bool IsAlive { get; set; } = true;

        public Monster(Location start) => Location = start;
        public abstract void Activate(FountainOfObjectsGame game);
    }
}
