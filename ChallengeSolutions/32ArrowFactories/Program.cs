
namespace _32ArrowFactories;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What type of arrow do you want? ");
        Console.WriteLine("1 - Get Elite Arrow");
        Console.WriteLine("2 - Get Beginner Arrow");
        Console.WriteLine("3 - Get Marksman Arrow");
        Console.WriteLine("4 - Get Custom Arrow");
        string input = Console.ReadLine();

        Arrow arrow = input switch
        {
            "1" => Arrow.CreateEliteArrow(),
            "2" => Arrow.CreateBeginnerArrow(),
            "3" => Arrow.CreateMarksmanArrow(),
            "4" => GetCustomArrow()
        };
        Console.WriteLine($"Your arrow cost is {arrow.GetCost()} gold.");

        Arrow GetCustomArrow()
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
    public class Arrow
    {
        public ArrowHead _arrowHead { get; }
        public Fletching _fletching { get; }
        public float _arrowLength { get; }

        public Arrow(ArrowHead arrowHead, Fletching fletching, float arrowLength)
        {
            _arrowHead = arrowHead;
            _fletching = fletching;
            _arrowLength = arrowLength;
        }


        public float GetCost()
        {
           float arrowHeadCost = _arrowHead switch
            {
                ArrowHead.steel => 10,
                ArrowHead.wood => 3,
                ArrowHead.obsidian => 5,
            };

            float fletchingCost = _fletching switch
            {
                Fletching.plastic => 10,
                Fletching.turkeyfeathers => 5,
                Fletching.goosefeathers => 3
            };

            float arrowLengthCost = _arrowLength * .05f;

            return arrowHeadCost + fletchingCost + arrowLengthCost;
        }
        public static Arrow CreateEliteArrow() => new Arrow(ArrowHead.steel, Fletching.plastic, 95);
        public static Arrow CreateBeginnerArrow() => new Arrow(ArrowHead.wood, Fletching.goosefeathers, 75);
        public static Arrow CreateMarksmanArrow() => new Arrow(ArrowHead.steel, Fletching.goosefeathers, 65);
    }
}
public enum ArrowHead { steel, wood, obsidian }
public enum Fletching { plastic, turkeyfeathers, goosefeathers }
