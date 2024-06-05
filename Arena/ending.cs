using Arena.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arena
{
    public partial class ending : Form
    {

        public int classsvt = 0;
        public bool win;
        public ending()
        {
            InitializeComponent();
        }

        private void ending_Load(object sender, EventArgs e)
        {
            API api = new API();


            api.l1.Hide();
            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.gojira2;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = classsvt.ToString();
            label2.Text = win.ToString();

            Soundtrack soundtrack = new Soundtrack();
            if (classsvt == 1 && win)
            {
                label3.Text = "You Survived";
                pictureBox1.Size = new Size(896, 533);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Resources.shinbutai;
                pictureBox1.Refresh();
                pictureBox1.Location = new Point(0, 0);

                this.Size = new Size(pictureBox1.Width, pictureBox1.Size.Height + 12);
                soundtrack.sp2.Stop();
                soundtrack.sp5.Play();
            }
            else if (classsvt == 2 && win)
            {
                label3.Text = "You Survived";
                pictureBox1.Size = new Size(896, 533);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Resources._0b9;
                pictureBox1.Refresh();
                pictureBox1.Location = new Point(0, 0);

                this.Size = new Size(pictureBox1.Width, pictureBox1.Size.Height + 12);
                this.BackgroundImage = Resources._0b9;

                soundtrack.sp2.Stop();
                soundtrack.sp4.Play();
            }
            else if (classsvt == 3 && win)
            {
                label3.Text = "You Survived";
                pictureBox1.Size = new Size(896, 533);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Resources.katyusha;
                pictureBox1.BackgroundImageLayout = ImageLayout.Center;
                pictureBox1.Refresh();
                pictureBox1.Location = new Point(0, 0);

                this.Name.Replace(this.Name, "won");
                this.Size = new Size(896, 533);
                this.BackgroundImage = Resources.katyusha;
                soundtrack.sp2.Stop();
                soundtrack.sp3.Play();
            }
            else if (!win)
            {
                label3.Hide();
                this.Size = new Size(1013, 597);
                this.BackgroundImage = Resources.social_credit;
                pictureBox1.Image = Resources.social_credit;
                pictureBox1.Size = this.Size;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Refresh();
                pictureBox1.Location = new Point(0, 0);


                soundtrack.sp2.Stop();
                soundtrack.sp6.PlayLooping();
            }
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ending_FormClosed(object sender, FormClosedEventArgs e)
        {
            Soundtrack soundtrack = new Soundtrack();
            soundtrack.sp1.Stop();
            soundtrack.sp2.Stop();
            soundtrack.sp3.Stop();
            soundtrack.sp4.Stop();
            soundtrack.sp5.Stop();
            soundtrack.sp6.Stop();
        }
    }
}
