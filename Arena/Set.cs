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
    public partial class Set : Form
    {
        Player player = new Player();

        public Set()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Set_Load(object sender, EventArgs e)
        {

        }

        private void start_button_Click(object sender, EventArgs e)
        {
            player.Name = Name_textBox.Text;

            level1_Aréna l1 = new level1_Aréna();
            l1.Show();
            l1.Focus();



        }

        private void japanese_button_Click(object sender, EventArgs e)
        {

        }

        private void american_button_Click(object sender, EventArgs e)
        {

        }
    }
}
