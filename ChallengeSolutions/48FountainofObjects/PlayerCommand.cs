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
            if(player.Row >= 0 && player.Row < 4) player.Row++;
        }
    }
    public class EastCommand: IPlayerCommand
    {
        public void Move(Player player)
        {
            if(player.Column >= 0 && player.Column < 4) player.Column++;
        }
    }
    public class SouthCommand: IPlayerCommand
    {
        public void Move(Player player)
        {
            if(player.Row > 0 && player.Row <=4) player.Row--;
        }
    }
    public class WestCommand: IPlayerCommand
    {
        public void Move(Player player)
        {
            if (player.Column > 0 & player.Column <= 4) player.Column--;
        }
    }
}
