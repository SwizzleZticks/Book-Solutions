using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58CharberryTrees
{
    public class RipeningHandler
    {
        public void OnRipeningEvent()
        {
            Console.WriteLine("A charberry fruit has ripened!");
        }
        public RipeningHandler(CharberryTree tree)
        {
            tree.Ripened += OnRipeningEvent;
        }
    }
}
