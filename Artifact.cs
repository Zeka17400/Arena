using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoRPG
{
    public class Artifact
    {
        string name;
        int damage;
        int maxhp;
        int price;

        public Artifact(string name, int damage, int maxhp, int price)
        {
            this.name = name;
            this.damage = damage;
            this.maxhp = maxhp;
            this.price = price;
        }
        public string GetName()
        {
            return name;
        }
        public int GetDamage()
        {
            return damage;
        }

        public int GetMaxHP()
        {
            return maxhp;
        }
        public int GetPrice()
        {
            return price;
        }
    }
}
