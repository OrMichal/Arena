using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arena
{
    public partial class settings : Form
    {
        level1_Aréna l1 = new level1_Aréna();
        Player player = new Player();
        string text;
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void japanese_button_Click(object sender, EventArgs e)
        {
            player.ClassID = 1;
        }

        private void American_button_Click(object sender, EventArgs e)
        {
            player.ClassID = 2;
        }

        private void start_button_Click(object sender, EventArgs e)
        {


            l1.Show();
            l1.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            player.Name = Name_textBox.Text.ToString();    
            label1.Text = player.ClassID.ToString();
        }
    }
}
