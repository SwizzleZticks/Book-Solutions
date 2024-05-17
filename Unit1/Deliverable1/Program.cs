namespace Deliverable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sodaStock = 100;
            int restockSoda = 40;

            int chipStock = 40;
            int restockChip = 20;

            int candyStock = 60;
            int restockCandy = 40;

            Console.WriteLine($"How many Sodas have been sold today? {sodaStock} are in stock");
            int sodaSales = int.Parse(Console.ReadLine());

            if (sodaSales > sodaStock)
            {
                Console.WriteLine("That value is too high. Stock not adjusted");
            }
            else
            {
                Console.WriteLine($"There are {sodaStock -= sodaSales} left");
            }

            Console.WriteLine($"How many Chips have been sold today? {chipStock} are in stock");
            int chipSales = int.Parse(Console.ReadLine());

            if (chipSales > chipStock)
            {
                Console.WriteLine("That value is too high. Stock not adjusted");
            }
            else
            {
                Console.WriteLine($"There are {chipStock -= chipSales} left");
            }

            Console.WriteLine($"How many Candy have been sold today? {candyStock} are in stock");
            int candySales = int.Parse(Console.ReadLine());

            if( candySales > candyStock)
            {
                Console.WriteLine("That value is too high. Stock not adjusted");
            }
            else
            {
                Console.WriteLine($"There are {candyStock -= chipSales} left");
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");

            if(sodaStock <= restockSoda)
            {
                Console.WriteLine("Soda needs to be restocked");
            }
            if(chipStock <= restockChip)
            {
                Console.WriteLine("Chips needs to be restocked");
            }
            if(candyStock <= restockCandy)
            {
                Console.WriteLine("Candy needs to be restocked");
            }
        }
    }
}
