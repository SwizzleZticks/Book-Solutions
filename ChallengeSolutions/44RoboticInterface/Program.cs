namespace _44RoboticInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            for (int index = 0; index < robot.Commands.Length; index++)
            {
                string? input = Console.ReadLine().ToLower();

                robot.Commands[index] = input switch
                {
                    "on" => new OnCommand(),
                    "off" => new OffCommand(),
                    "north" => new NorthCommand(),
                    "south" => new SouthCommand(),
                    "west" => new WestCommand(),
                    "east" => new EastCommand(),
                    _ => new OffCommand()
                };
            }

            Console.WriteLine();
            robot.Run();
        }
    }
}
