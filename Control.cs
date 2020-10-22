using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoRPG
{
    public static class Control
    {
        static List<Location> locations;

        public static void Standard()
        {
            locations = new List<Location>();

            locations.Add(new Location("Начальная локация", 1));
            locations[0].AddPlace(new Place("Начальное место", 1));
            locations[0].GetPlaces()[0].AddEnemy(new Enemy(20, 5, 10, 10, "Скелетик"), 10);
        }

        public static List<Location> GetLocations()
        {
            return locations;
        }
    }
}
