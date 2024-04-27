using System;
using System.Drawing;
using TheCard;

namespace PoopFart
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (CardColor color in Enum.GetValues(typeof(CardRank)))
            {
                foreach (CardRank rank in Enum.GetValues(typeof(CardRank)))
                {
                    Card card = new Card(color, rank);
                    System.Console.WriteLine($"The {card.Color} {card.Rank}");
                }
            }
        }
    }
}
