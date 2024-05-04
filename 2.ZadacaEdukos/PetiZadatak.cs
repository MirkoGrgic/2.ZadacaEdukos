using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ZadacaEdukos
{
    public class Location
    {
        public DateTime CreatedAt { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
            CreatedAt = DateTime.Now;
        }
    }

    public class Path
    {
        private List<Location> locations;

        public Path()
        {
            locations = new List<Location>();
        }

        public void Add(Location location)
        {
            locations.Add(location);
        }

        public void Remove(Location location)
        {
            locations.Remove(location);
        }
    }
}
