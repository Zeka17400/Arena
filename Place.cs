using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoRPG
{
    public class Place
    {
        string name;
        int needlevel;
        List<Enemy> enemylist = new List<Enemy>();

        public Place(string name, int needlevel)
        {
            this.name = name;
            this.needlevel = needlevel;
        }

        public void AddEnemy(Enemy new_enemy, int number_of_enemies)
        {
            for (int i = 1; i < number_of_enemies; i++)
            {
                enemylist.Add(new_enemy);
            }
        }

        public List<Enemy> GetEnemies()
        {
            return enemylist;
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
