using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoRPG
{
    public class Location
    {
        public string name;
        public int needlevel;
        List<Place> places = new List<Place>();

        public Location(string name, int needlevel)
        {
            this.name = name;
            this.needlevel = needlevel;
        }

        public void AddPlace(Place new_place)
        {
            places.Add(new_place);
        }

        public List<Place> GetPlaces()
        {
            return places;
        }

        public string GetName()
        {
            return name;
        }

        public int GetLevel()
        {
            return needlevel;
        }
    }
}
