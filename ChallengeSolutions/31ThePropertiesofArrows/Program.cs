namespace _31ThePropertiesofArrows
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Arrow arrow = GetArrow();
            Console.WriteLine($"Your arrow cost is {arrow.GetCost()} gold.");

            Arrow GetArrow()
            {
                ArrowHead arrowHead = GetArrowHead();
                Fletching fletching = GetFletching();
                float arrowLength = GetLength();

                return new Arrow(arrowHead, fletching, arrowLength);
            }

            ArrowHead GetArrowHead()
            {
                Console.WriteLine("What type of arrowhead would you like(steel,wood,obsidian)? ");
                string userInput = Console.ReadLine();

                return userInput switch
                {
                    "steel" => ArrowHead.steel,
                    "wood" => ArrowHead.wood,
                    "obsidian" => ArrowHead.obsidian
                };
            }

            Fletching GetFletching()
            {
                Console.WriteLine("What type of fletching would you like(plastic,turkey feathers,goose feathers)");
                string userInput = Console.ReadLine();

                return userInput switch
                {
                    "plastic" => Fletching.plastic,
                    "turkey feathers" => Fletching.turkeyfeathers,
                    "goose feathers" => Fletching.goosefeathers
                };
            }

            float GetLength()
            {
                float length = 0;

                while (length < 60 || length > 100)
                {
                    Console.Write("Arrow length (between 60 and 100): ");
                    length = Convert.ToSingle(Console.ReadLine());
                }

                return length;
            }
        }
    }
    enum ArrowHead { steel, wood, obsidian }
    enum Fletching { plastic, turkeyfeathers, goosefeathers }
}
