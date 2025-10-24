using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58CharberryTrees
{
    public class Harvester
    {
        private int _harvestedCount;
        private CharberryTree _tree;

        public void Harvest()
        {
            _tree.Ripe = false;
            _harvestedCount++;
            Console.WriteLine($"{_harvestedCount} trees harvested");
        }
        public Harvester(CharberryTree tree) 
        { 
            _tree = tree;
            _tree.Ripened += Harvest;
        }
    }
}
