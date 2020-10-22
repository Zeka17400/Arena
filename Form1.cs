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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShopInventar.standard_artifacts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.Standard();
            thisUpdate();
        }

        public void thisUpdate()
        {
            Character.WhereToGo();
            Character.SetHP(Character.GetMaxHP());
            listBox_inventory.Items.Clear();
            textBox_HP.Text = $"{Character.GetHP()} из {Character.GetMaxHP()}";
            textBox_DMG.Text = Convert.ToString(Character.GetDMG());
            textBox_GOLD.Text = Convert.ToString(Character.GetGold());
            textBox_EXP.Text = $"{Character.GetExp()} из {Character.nextlevel()}";
            textBox_Level.Text = Convert.ToString(Character.GetLVL());
            textBox_Points.Text = Convert.ToString(Character.GetPoints());
            for (int i = 0; i < Character.GetInventory().Count; i++)
            {
                listBox_inventory.Items.Add(Character.GetInventory()[i].GetName() + " - " + $"Урон: {Character.GetInventory()[i].GetDamage()}, Доп.ХП: {Character.GetInventory()[i].GetMaxHP()}");
            }
        }

        private void Autorpg_CheckedChanged(object sender, EventArgs e)
        {
            if (autorpg.Checked)
            {
                Character.SetAutoRPG(true);
                timer1.Enabled = true;
            }
            else
            {
                Character.SetAutoRPG(false);
                timer1.Enabled = false;
            }
        }

        public void StartTimer()
        {
            timer1.Enabled = true;
        }
        private void Button_SHOP_Click(object sender, EventArgs e)
        {
            Shop openshop = new Shop();
            openshop.ShowDialog();
        }

        private void Button_LOCATION_Click(object sender, EventArgs e)
        {
            Map openmap = new Map();
            openmap.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            thisUpdate();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Character.GetBuyed() == false)
            {
                timer1.Enabled = false;
                Button_SHOP_Click(sender, e);
            }
            else
            {
                timer1.Enabled = false;
                Character.CharacterUp();
                Button_LOCATION_Click(sender,e);
            }
        }
    }
}
