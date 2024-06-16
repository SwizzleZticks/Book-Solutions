using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace _47ColoredItems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColoredItem<Sword> sword = new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);
            ColoredItem<Axe> axe = new ColoredItem<Axe>(new Axe(), ConsoleColor.Green);
            ColoredItem<Bow> bow = new ColoredItem<Bow> (new Bow(), ConsoleColor.Red);

            sword.Display();
            axe.Display();
            bow.Display();
        }
    }

    public class Sword{}
    public class Bow{}
    public class Axe{}

    public class ColoredItem<T>
    {
        public T Item { get; }
        public ConsoleColor Color { get; }
        public ColoredItem(T item, ConsoleColor color)
        {
            Item = item;
            Color = color;
        }

        public void Display()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(Item);
        }
    }

}
