using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();
        // this is internal because the only other class to use this method is WorldFactory
        internal void AddLocation(int xCoordinate, int yCoordinate, string name, string description, byte[] imageFile)
        {
            Location loc = new Location();
            loc.XCoordinate = xCoordinate;
            loc.YCoordinate = yCoordinate;
            loc.Name = name;
            loc.Description = description;
            loc.ImageFile = imageFile;
            _locations.Add(loc);
        }

        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location location in _locations)
            {
                bool xMatch = location.XCoordinate == xCoordinate;
                bool yMatch = location.YCoordinate == yCoordinate;
                if (xMatch && yMatch)
                {
                    return location;
                }
            }
            return null;
        }
    }
}
