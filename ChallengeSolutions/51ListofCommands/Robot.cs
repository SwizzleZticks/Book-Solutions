
namespace _51ListofCommands
{
    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPowered { get; set; }
        public List<IRobotCommand> Commands { get; } = new List<IRobotCommand>();
        public void Run()
        {
            foreach (IRobotCommand? command in Commands)
            {
                command?.Run(this);
                Console.WriteLine($"[{X} {Y} {IsPowered}]");
            }
        }
    }
}
