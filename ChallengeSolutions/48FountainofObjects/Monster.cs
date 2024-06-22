using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48FountainofObjects
{
    public abstract class Monster
    {
        public Location Location { get; set; }

        public bool IsAlive { get; set; } = true;

        public Monster(Location start) => Location = start;
        public abstract void Activate(FountainOfObjectsGame game);
    }

    public class Maelstrom : Monster
    {
        public Maelstrom (Location start) : base(start) { }
        public override void Activate(FountainOfObjectsGame game)
        {
            ConsoleHelper.WriteLine("You have encountered a maelstrom and have been swept away to another room!", ConsoleColor.Magenta);
            game.Player.Location = Clamp(new Location(game.Player.Location.Row - 1, game.Player.Location.Column + 2), game.Map.Rows, game.Map.Columns);
            Location = Clamp(new Location(Location.Row + 1, Location.Column - 2), game.Map.Rows, game.Map.Columns);
        }
        private Location Clamp(Location location, int totalRows, int totalColumns)
        {
            int row = location.Row;
            if (row < 0) row = 0;
            if (row >= totalRows) row = totalRows - 1;

            int column = location.Column;
            if (column < 0) column = 0;
            if (column >= totalColumns) column = totalColumns - 1;

            return new Location(row, column);
        }
    }
}
