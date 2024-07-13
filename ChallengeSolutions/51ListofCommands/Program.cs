
namespace _51ListofCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            while (true)
            {
                string? input = Console.ReadLine();

                if (input == "stop") break;

                robot.Commands.Add(input switch
                {
                    "on" => new OnCommand(),
                    "off" => new OffCommand(),
                    "north" => new NorthCommand(),
                    "south" => new SouthCommand(),
                    "east" => new EastCommand(),
                    "west" => new WestCommand(),
                });
            }

            Console.WriteLine();

            robot.Run();
        }
    }
}
