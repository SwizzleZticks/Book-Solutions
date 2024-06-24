
namespace _51ListofCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            string? input = null;

            while (input != "stop") 
            {
                Console.WriteLine("Please enter a command(on,off,north,south,west,east, or stop to exit:");
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "on":
                        new OnCommand();
                        break;
                    case "off":
                        new OffCommand();
                        break;
                    case "north":
                        new NorthCommand();
                        break;
                    case "south":
                        new SouthCommand();
                        break;
                    case "west":
                        new WestCommand();
                        break;
                    case "east":
                        new EastCommand();
                        break;
                    case "stop":
                        break;                      
                };
            }

            Console.WriteLine();
            robot.Run();
        }
    }
}
