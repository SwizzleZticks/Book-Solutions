namespace _43TheOldRobot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();

            for (int index = 0; index < robot.Commands.Length; index++)
            {
                string? input = Console.ReadLine().ToLower();

                RobotCommand newCommand = input switch
                {
                    "on" => new OnCommand(),
                    "off" => new OffCommand(),
                    "north" => new NorthCommand(),
                    "south" => new SouthCommand(),
                    "west" => new WestCommand(),
                    "east" => new EastCommand(),
                    _ => new OffCommand()
                } ;
                robot.Commands[index] = newCommand;
            }

            Console.WriteLine();
            robot.Run();
        }
    }
}
