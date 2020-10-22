using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoRPG
{
    public class Enemy
    {
        int hp;
        int dmg;
        int exp;
        int money;
        string name;

        public Enemy(int hp, int dmg, int exp, int money, string name)
        {
            this.hp = hp;
            this.dmg = dmg;
            this.exp = exp;
            this.money = money;
            this.name = name;
        }

        public int GetHP()
        {
            return hp;
        }

        public int GetDMG()
        {
            return dmg;
        }

        public int GetEXP()
        {
            return exp;
        }

        public string GetName()
        {
            return name;
        }

        public int GetGold()
        {
            return money;
        }
        public void minushp(int dmg)
        {
            hp -= dmg;
        }
    }
}
