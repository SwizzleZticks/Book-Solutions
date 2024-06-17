using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48FountainofObjects
{
    public interface ICommand
    {
        public void Execute(FountainOfObjectsGame game);
    }
    
    public class MoveCommand : ICommand
    {
        Direction Direction { get; }

        public MoveCommand(Direction direction)
        {
            Direction = direction;
        }

        public void Execute(FountainOfObjectsGame game)
        {

        }
    }
}
public enum Direction
{
    North,
    East,
    South,
    West
}