namespace _41PackingInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack(10, 20, 30);
            while (true)
            {
                Console.WriteLine($"Pack is currently at {pack.CurrentCount}/{pack.MaxCount} and weight is {pack.CurrentWeight}/{pack.MaxWeight}");

                Console.WriteLine("Please choose a item you would like to add to the pack.");
                Console.WriteLine("1 => Arrow");
                Console.WriteLine("2 => Bow");
                Console.WriteLine("3 => Rope");
                Console.WriteLine("4 => Water");
                Console.WriteLine("5 => Food Rations");
                Console.WriteLine("6 => Sword");
                int userInput = Convert.ToInt32(Console.ReadLine());

                InventoryItem newItem = userInput switch
                {
                    1 => new Arrow(),
                    2 => new Bow(),
                    3 => new Rope(),
                    4 => new Water(),
                    5 => new FoodRations(),
                    6 => new Sword()
                };

                if (!pack.Add(newItem))
                {
                    Console.WriteLine("Could not add this item.");
                }

                Console.Clear();
            }
        }
    }
}
