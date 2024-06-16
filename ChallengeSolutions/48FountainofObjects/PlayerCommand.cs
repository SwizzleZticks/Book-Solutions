using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48FountainofObjects
{
    public interface IPlayerCommand
    {
        public void Move(Player player);
    }

    public class NorthCommand: IPlayerCommand
    {
        public void Move(Player player)
        {

        }
    }
    public class EastCommand: IPlayerCommand
    {
        public void Move(Player player)
        {

        }
    }
    public class SouthCommand: IPlayerCommand
    {
        public void Move(Player player)
        {

        }
    }
    public class WestCommand: IPlayerCommand
    {
        public void Move(Player player)
        {

        }
    }
}
