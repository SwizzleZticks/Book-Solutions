using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41PackingInventory
{
    public class Pack
    {
        public int MaxCount { get; set; }
        public float MaxWeight { get; set; }
        public float MaxVolume { get; set; }

        private InventoryItem[] _items;

        public int CurrentCount { get; private set; }
        public float CurrentWeight { get; private set; }
        public float CurrentVolume { get; private set; }

        public Pack(int maxCount, float maxWeight, float maxVolume)
        {
            MaxCount = maxCount;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;

            _items = new InventoryItem[maxCount];
        }

        public bool Add(InventoryItem item)
        {
            if(CurrentCount >= MaxCount)
            {
                return false;
            }
            if(CurrentWeight + item.Weight > MaxWeight)
            {
                return false;
            }
            if(CurrentVolume + item.Volume > MaxVolume)
            {
                return false;
            }

            _items[CurrentCount] = item;
            CurrentCount++;
            CurrentWeight += item.Weight;
            CurrentVolume += item.Volume;
            return true;
        }
    }
}
