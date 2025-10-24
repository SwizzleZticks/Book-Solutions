using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58CharberryTrees
{
    public class CharberryTree
    {
        private Random _random = new Random();
        public bool Ripe { get; set; }
        public event Action? Ripened;
        public void MaybeGrow()
        {
            // Only a tiny chance of ripening each time, but we try a lot!
            if (_random.NextDouble() < 0.00000001 && !Ripe)
            {
                Ripe = true;
                Ripened?.Invoke();
            }
        }
    }
}
