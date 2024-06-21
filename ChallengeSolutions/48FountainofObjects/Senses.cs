using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48FountainofObjects
{
    public interface ISense
    {
        // Returns whether the player should be able to sense the thing in question.
        bool CanSense(FountainOfObjectsGame game);

        // Displays the sensed information. (Assumes `CanSense` was called first and returned `true`.)
        void DisplaySense(FountainOfObjectsGame game);
    }

    // Represents the player's ability to sense the light in the entrance room.
    public class LightInEntranceSense : ISense
    {
        // Returns `true` if the player is in the entrance room.
        public bool CanSense(FountainOfObjectsGame game) => game.Map.GetRoomTypeAtLocation(game.Player.Location) == RoomType.Entrance;

        // Displays the appropriate message if the player can see the light from outside the caverns.
        public void DisplaySense(FountainOfObjectsGame game) => ConsoleHelper.WriteLine("You see light in this room coming from outside the cavern. This is the entrance.", ConsoleColor.Yellow);
    }

    // Represents the player's ability to sense the dripping of a deactivated fountain or rushing waters of an activated fountain.
    public class FountainSense : ISense
    {
        // Returns `true` if the player is in the fountain room.
        public bool CanSense(FountainOfObjectsGame game) => game.Map.GetRoomTypeAtLocation(game.Player.Location) == RoomType.Fountain;

        // Displays the appropriate message depending on whether the fountain is enabled or disabled.
        public void DisplaySense(FountainOfObjectsGame game)
        {
            if (game.IsFountainOn) ConsoleHelper.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!", ConsoleColor.DarkCyan);
            else ConsoleHelper.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!", ConsoleColor.DarkCyan);
        }
    }
}
