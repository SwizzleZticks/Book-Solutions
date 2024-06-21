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
            Location currentLocation = game.Player.Location;
            Location newLocation = Direction switch
            {
                Direction.North => new Location(currentLocation.Row - 1, currentLocation.Column),
                Direction.South => new Location(currentLocation.Row + 1, currentLocation.Column),
                Direction.West => new Location(currentLocation.Row, currentLocation.Column - 1),
                Direction.East => new Location(currentLocation.Row, currentLocation.Column + 1)
            };

            if (game.Map.IsOnMap(newLocation))
                game.Player.Location = newLocation;
            else
                ConsoleHelper.WriteLine("There is a wall there.", ConsoleColor.Red);
        }
    }
    public class EnableFountain : ICommand
    {
        public void Execute(FountainOfObjectsGame game)
        {
            if (game.Map.GetRoomTypeAtLocation(game.Player.Location) == RoomType.Fountain) game.IsFountainOn = true;
            else ConsoleHelper.WriteLine("The fountain is not in this room. There was no effect.", ConsoleColor.Red);
        }
    }
}
public enum Direction
{
    North,
    South,
    West,
    East
}