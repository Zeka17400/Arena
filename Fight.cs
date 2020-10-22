using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvtoRPG
{
    public partial class Fight : Form
    {
        public Location location;
        public Place place;

        public Fight()
        {
            InitializeComponent();
        }

        private void Fight_Load(object sender, EventArgs e)
        {
            Control.Standard();
            for (int i = 0; i < place.GetEnemies().Count; i++)
            {
                enemylist.Items.Add(place.GetEnemies()[i].GetName() + " " + i);
            }
        }

        private void AttackTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (place.GetEnemies()[0].GetHP() <= 0)
                {
                    combatlog.TopIndex = combatlog.Items.Add(string.Format("{0} побежден", place.GetEnemies()[0].GetName()));
                    Character.setexp(place.GetEnemies()[0].GetEXP());
                    Character.lvlup();
                    Character.setgold(place.GetEnemies()[0].GetGold());
                    place.GetEnemies().RemoveAt(0);
                    enemylist.Items.RemoveAt(0);
                }
                label1.Text = string.Format("HP: {0}", Character.GetHP());

                place.GetEnemies()[0].minushp(Character.GetDMG());
                combatlog.TopIndex = combatlog.Items.Add($"Вы нанесли {Character.GetDMG()} урона по {place.GetEnemies()[0].GetName()}");

                Character.MinusHP(place.GetEnemies()[0].GetDMG());
                combatlog.Items.Add($"Вы получили {place.GetEnemies()[0].GetDMG()} урона");

            }
            catch
            {
                combatlog.TopIndex = combatlog.Items.Add("Все враги на локации побеждены");
                this.Close();
            }
            if (Character.GetHP() <= 30)
            {
                this.Close();
            }
        }

        private void Fight_FormClosed(object sender, FormClosedEventArgs e)
        {
            Character.setBuyed(false);
            (Application.OpenForms["Form1"] as Form1).thisUpdate();
            if (Character.GetAutoRPG())
            {
                (Application.OpenForms["Form1"] as Form1).StartTimer();
            }
        }
    }
}
