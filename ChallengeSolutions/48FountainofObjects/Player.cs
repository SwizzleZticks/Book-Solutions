using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48FountainofObjects
{
    public class Player
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public IPlayerCommand? Command { get; set; }

        public void Move()
        {
            Command?.Move(this);
        }
        public void Interact()
        {
            Command?.Interact();//gonna have to use a method to get that cells state of object
        }
    }
}
