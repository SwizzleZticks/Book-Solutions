using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43TheOldRobot
{
    public abstract class RobotCommand
    {
        public abstract void Run(Robot robot);
    }

    public class OnCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            robot.IsPowered = true;
        }   
    }

    public class OffCommand : RobotCommand 
    {
        public override void Run(Robot robot)
        {
            robot.IsPowered = false;
        }
    }

    public class NorthCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered == true)
            {
                robot.Y++;
            }
        }
    }

    public class SouthCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered == true)
            {
                robot.Y--;
            }
        }
    }

    public class WestCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered == true)
            {
                robot.X--;
            }
        }
    }

    public class EastCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if(robot.IsPowered == true)
            {
                robot.X++;
            }
        }
    }
}
