using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Jannik";
            CurrentPlayer.Gold = 1_000_000;
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            CurrentLocation = new Location();
            CurrentLocation.Name = "Home";
            CurrentLocation.XCoordinate = 0;
            CurrentLocation.YCoordinate = -1;
            CurrentLocation.Description = "This is your house";
            //CurrentLocation.ImageName = "Engine/Images/Locations/SpiderForest.png";
            CurrentLocation.ImageName = "/Engine;component/Images/Locations/SpiderForest.png";
            // the following does work but is ugly
            //CurrentLocation.ImageName = "C:/Users/nanni/source/repos/SOSCSRPG/Engine/Images/Locations/SpiderForest.png";
        }
    }
}
