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
    public partial class Shop : Form
    {
        int tick = 0;
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            UpdateShop();
            if (Character.GetAutoRPG())
            {
                ShopTimer.Enabled = true;
            }
            else
            {
                ShopTimer.Enabled = false;
            }
        }

        private void Button_Pokypka_Click(object sender, EventArgs e)
        {
            if (Character.GetGold() >= ShopInventar.getShop()[listBox1.SelectedIndex].GetPrice())
            {
                ShopInventar.BoughtArtifact(ShopInventar.getShop()[listBox1.SelectedIndex]);
            }
            UpdateShop();
        }

        private void UpdateShop()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < ShopInventar.getShop().Count; i++)
            {
                listBox1.Items.Add(ShopInventar.getShop()[i].GetName() + " - " + $"Урон: {ShopInventar.getShop()[i].GetDamage()}; Доп.ХП: {ShopInventar.getShop()[i].GetMaxHP()}; Цена: {ShopInventar.getShop()[i].GetPrice()}");
            }
        }

        private void Button_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Shop_FormClosed(object sender, FormClosedEventArgs e)
        {
            (Application.OpenForms["Form1"] as Form1).thisUpdate();
            if (Character.GetAutoRPG())
            {
                (Application.OpenForms["Form1"] as Form1).StartTimer();
            }
        }

        private void ShopTimer_Tick(object sender, EventArgs e)
        {
            if (tick == 0)
            {
                if (ShopInventar.getShop().Count != 0)
                {
                    if (Character.GetGold() >= ShopInventar.getShop()[0].GetPrice())
                    {
                        ShopInventar.BoughtArtifact(ShopInventar.getShop()[0]);
                    }
                    else
                    {
                        Character.setBuyed(true);
                    }
                }
                tick += 1;
            }
            else if (tick == 1)
            {
                Character.setBuyed(true);
                Button_EXIT_Click(sender, e);
                tick = 0;
            }
            UpdateShop();
        }
    }
}
