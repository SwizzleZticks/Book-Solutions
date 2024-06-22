﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48FountainofObjects
{
    public interface ISense
    {
        bool CanSense(FountainOfObjectsGame game);

        void DisplaySense(FountainOfObjectsGame game);
    }

    public class LightInEntranceSense : ISense
    {
        public bool CanSense(FountainOfObjectsGame game) => game.Map.GetRoomTypeAtLocation(game.Player.Location) == RoomType.Entrance;

        public void DisplaySense(FountainOfObjectsGame game) => ConsoleHelper.WriteLine("You see light in this room coming from outside the cavern. This is the entrance.", ConsoleColor.Yellow);
    }

    public class FountainSense : ISense
    {
        public bool CanSense(FountainOfObjectsGame game) => game.Map.GetRoomTypeAtLocation(game.Player.Location) == RoomType.Fountain;

        public void DisplaySense(FountainOfObjectsGame game)
        {
            if (game.IsFountainOn) ConsoleHelper.WriteLine("You hear the rushing waters from the Fountain of Objects. It has been reactivated!", ConsoleColor.DarkCyan);
            else ConsoleHelper.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!", ConsoleColor.DarkCyan);
        }
    }

    public class PitSense : ISense
    {
        public bool CanSense(FountainOfObjectsGame game) => game.Map.HasNeighborWithType(game.Player.Location, RoomType.Pit);
        public void DisplaySense(FountainOfObjectsGame game) => ConsoleHelper.WriteLine("You feel a draft there is a pit in a nearby room.", ConsoleColor.Yellow);
    }        
}