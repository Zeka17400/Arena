using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoRPG
{
    public static class Character
    {
        static int hp = 100;
        static int maxhp = 100;
        static int damage = 5;
        static int exp = 0;
        static int gold = 0;
        static int level = 1;
        static bool AutoRPG = false;
        static int points;
        static bool buyed = false;
        static Location GoLocation;
        static Place GoPlace;
        static List<Artifact> inventory = new List<Artifact>();


        public static int GetHP()
        {
            return hp;
        }

        public static int GetMaxHP()
        {
            return maxhp;
        }
        
        public static int GetDMG()
        {
            return damage;
        }

        public static int GetExp()
        {
            return exp;
        }

        public static int GetLVL()
        {
            return level;
        }

        public static int GetGold()
        {
            return gold;
        }

        public static int GetPoints()
        {
            return points;
        }

        public static bool GetBuyed()
        {
            return buyed;
        }

        public static void SetHP(int new_hp)
        {
            hp = new_hp;
        }

        public static void lvlup()
        {
            if (exp >= 50 * level)
            {
                points += 2;
                level += 1;
                exp = 0;
            }
        }

        public static int nextlevel()
        {
            return 50 * level;
        }

        public static void setexp(int addexp)
        {
            exp += addexp;
        }

        public static void setgold(int addgold)
        {
            gold += addgold;
        }

        public static void MinusHP(int enemydamage)
        {
            hp -= enemydamage;
        }

        public static void statgain_dmg(int newdmg)
        {
            if (points > 0)
            {
                damage += newdmg;
                points -= 1;
            }
        }

        public static void setBuyed(bool buyed_)
        {
            buyed = buyed_;
        }

        public static void SetItem(Artifact newart)
        {
            maxhp += newart.GetMaxHP();
            damage += newart.GetDamage();
        }

        public static void statgain_maxhp(int newmaxhp)
        {
            if (points > 0)
            {
                damage += newmaxhp;
                points -= 1;
            }
        }

        public static List<Artifact> GetInventory()
        {
            return inventory;
        }

        public static void CharacterUp()
        {
            statgain_dmg(5);
            statgain_maxhp(10);
        }

        public static bool GetAutoRPG()
        {
            return AutoRPG;
        }

        public static void SetAutoRPG(bool state)
        {
            AutoRPG = state;
        }

        public static Location GetGoLocation()
        {
            return GoLocation;
        }

        public static Place GetGoPlace()
        {
            return GoPlace;
        }

        public static void WhereToGo()
        {
            for (int i = 0; i < Control.GetLocations().Count; i++)
            {
                if (Control.GetLocations()[i].GetLevel() <= level)
                {
                    GoLocation = Control.GetLocations()[i];
                    for (int j = 0; j < GoLocation.GetPlaces().Count; j++)
                    {
                        if (GoLocation.GetPlaces()[j].GetLevel() <= level)
                        {
                             GoPlace = GoLocation.GetPlaces()[j];
                        }
                    }
                }
            }
        }
    }
}
