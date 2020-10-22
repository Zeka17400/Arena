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
    public partial class Map : Form
    {
        int tick = 0;
        public Map()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (Character.GetAutoRPG())
            {
                TransferTimer.Enabled = true;
            }
            else
            {
                TransferTimer.Enabled = false;
            }
            for (int i = 0; i < Control.GetLocations().Count; i++)
            {
                comboBox1.Items.Add(Control.GetLocations()[i].GetName());
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            for (int i = 0; i < Control.GetLocations()[comboBox1.SelectedIndex].GetPlaces().Count; i++)
            {
                comboBox2.Items.Add(Control.GetLocations()[comboBox1.SelectedIndex].GetPlaces()[i].GetName());
            }
        }

        private void Button_map_Click(object sender, EventArgs e)
        {
            Fight fight = new Fight();
            fight.location = Control.GetLocations()[comboBox1.SelectedIndex];
            fight.place = Control.GetLocations()[comboBox1.SelectedIndex].GetPlaces()[comboBox2.SelectedIndex];
            fight.ShowDialog(this);
        }

        private void TransferTimer_Tick(object sender, EventArgs e)
        {
            if (tick == 0)
            {
                comboBox1.SelectedIndex = Control.GetLocations().IndexOf(Character.GetGoLocation());
                tick += 1;
            }
            else if (tick == 1)
            {
                comboBox2.SelectedIndex = Character.GetGoLocation().GetPlaces().IndexOf(Character.GetGoPlace());
                tick += 1;
            }
            else if (tick == 2)
            {
                TransferTimer.Enabled = false;
                Button_map_Click(sender, e);
                tick = 0;
                this.Close();
            }
            
        }
    }
}
