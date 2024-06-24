
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
                        robot.Commands.Add(new OnCommand());
                        break;
                    case "off":
                        robot.Commands.Add(new OffCommand());
                        break;
                    case "north":
                        robot.Commands.Add(new NorthCommand());
                        break;
                    case "south":
                        robot.Commands.Add(new SouthCommand());
                        break;
                    case "west":
                        robot.Commands.Add(new WestCommand());
                        break;
                    case "east":
                        robot.Commands.Add(new EastCommand());
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
