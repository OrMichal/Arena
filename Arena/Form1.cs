using System.Media;

namespace Arena
{
    public partial class Aréna : Form
    {
         
        Soundtrack soundtrack = new Soundtrack();
        Player player = new Player();
        
        public Aréna()
        {
            soundtrack.sp1.PlayLooping();

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            API api = new API();
            api.l1.classID = player.ClassID;
            api.l1.playerName = textBox1.Text.ToString();
            api.l1.Show();
            api.l1.Focus();



        }

        private void end_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void japanese_button_Click(object sender, EventArgs e)
        {
            player.ClassID = 1;

        }

        private void american_button_Click(object sender, EventArgs e)
        {
            player.ClassID = 2;
        }

        private void apply_button_Click(object sender, EventArgs e)
        {
            name_label.Text = "Name: " + textBox1.Text.ToString();
            class_label.Text = "Class: " + player.ClassID.ToString();
        }

        private void Russian_button_Click(object sender, EventArgs e)
        {
            player.ClassID = 3;
        }
    }
}
