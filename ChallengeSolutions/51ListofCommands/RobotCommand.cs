namespace _51ListofCommands
{
    public interface IRobotCommand
    {
        public void Run(Robot robot);
    }

    public class OnCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.IsPowered = true;
        }
    }

    public class OffCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            robot.IsPowered = false;
        }
    }

    public class NorthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered == true)
            {
                robot.Y++;
            }
        }
    }

    public class SouthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered == true)
            {
                robot.Y--;
            }
        }
    }

    public class WestCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered == true)
            {
                robot.X--;
            }
        }
    }

    public class EastCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered == true)
            {
                robot.X++;
            }
        }
    }
}
