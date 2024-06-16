using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48FountainofObjects
{
    public class Player
    {
        public Location StartLocation { get; set; } = new Location(0,0);
        public IPlayerCommand? Command { get; set; }

        public void Move()
        {
            Command?.Move(this);
        }
    }
}
