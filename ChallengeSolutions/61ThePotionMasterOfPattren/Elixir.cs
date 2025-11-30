using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _61ThePotionMasterOfPattren.Enums;

namespace _61ThePotionMasterOfPattren
{
    public class Potion
    {
        public List<IngredientType> Ingredients;
        public PotionType PotionType { get; set; } = PotionType.Water;

        public Potion() 
        {
            Ingredients = new List<IngredientType>();
        }
    }
}
