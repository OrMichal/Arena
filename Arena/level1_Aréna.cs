using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arena
{
    public partial class level1_Aréna : Form
    {
        
        ending end = new ending();
        Stopwatch sw = new Stopwatch();
        public int classID = 0;
        Ai ai = new Ai();
        Soundtrack soundtrack = new Soundtrack();
        public bool MouseHold = false;
        Player player = new Player();
        Enemy enemy1 = new Enemy(400000, 30, "Xing Ping of the Communist party");
        Enemy enemy2 = new Enemy(500000, 40, "Miloš of the Becherovka");
        Enemy enemy3 = new Enemy(1000000, 50, "Krteček of the Zahrada");
        Enemy ActiveEnemy = new Enemy(10, 10, " ");
        List<Enemy> enemies = new List<Enemy>();
        Random r = new Random();
        public bool hit = false;

        string ActiveEnemy_name;
        int ActiveEnemy_maxHp;
        int ActiveEnemy_dmg;
        int ActiveEnemy_finalDmg;

        public string playerName = "";
        public bool win = false;

        public level1_Aréna()
        {
            soundtrack.sp1.Stop();
            soundtrack.sp2.PlayLooping();
            enemy1.EnemyHP = enemy1.EnemyMaxHP;

            player.PlayerMove = false;
            InitializeComponent();
            timer1.Start();
            Enemy_Timer.Start();
            timer2.Start();
            Starting_timer.Start();

            player.g = panel1.CreateGraphics();
            player.pen = new Pen(Color.Black, 10);

            player.meißLokatonX = 0;
            player.meißlokatonY = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseHold = true;
            player.mouseHold = true;
            player.PlayerMove = true;
            player.meißLokatonX = e.X;
            player.meißlokatonY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && player.katana && MouseHold)
            {
                player.attack(e, enemy1);
                player.meißLokatonX = e.X;
                player.meißlokatonY = e.Y;
            }

            if (player.katana && classID == 1)
            {
                player.meißLokatonX = e.X;
                player.meißlokatonY = e.Y;
            }

            if (classID == 1)
            {
                hitbox.Location = new Point(player.meißLokatonX, player.meißlokatonY);
            }


        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (player.katana)
            {
                player.PlayerMove = false;
                player.meißLokatonX = -1;
                player.meißlokatonY = -1;
                MouseHold = false;
                player.mouseHold = false;
            }

            if (classID == 2)
            {
                stratagemBox.Location = new Point(player.meißLokatonX + 10, player.meißlokatonY + 90);
            }

            timer5.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (classID == 2)
            {
                stratagemBox.Size = new Size(20, 20);
                stratagemBox.Location = new Point(Enemy_box1.Location.X + 50, Enemy_box1.Location.Y + 120);
                stratagemBox.Image = Properties.Resources.crosshai;
                stratagemBox.BackgroundImageLayout = ImageLayout.Stretch;
                stratagemBox.Refresh();
            }


            ActiveEnemy.EnemyX = Enemy_box1.Location.X;
            ActiveEnemy.EnemyY = Enemy_box1.Location.Y;
            label1.Text = " " + progressBar1.Value + "/" + ActiveEnemy.EnemyMaxHP;

            if (classID == 1 && player.Gojira)
            {
                gojiraHead_box.Show();
                gojira_laserBox.Show();
                player.GojiraAttack(progressBar1, gojiraHead_box, Enemy_box1, gojira_laserBox, pictureBox4, 40);
            }
            else if (classID == 2 && player.railgun)
            {
                targeter_box.Hide();
                stratagemBox.Hide();
                player.railgunShoot = true;
                player.railGunAttack(progressBar1, Enemy_box1, targeter_box, tester_box);
            }
            else if (classID == 3 && player.putinSummon)
            {
                putin_box.Show();
                putin_laser.Show();
                player.GojiraAttack(progressBar1, putin_box, Enemy_box1, putin_laser, pictureBox4, 400);
            }



            HP_bar.Step = -ActiveEnemy.EnemyFinalDmg;

        }

        private void Enemy_Timer_Tick(object sender, EventArgs e)
        {
            siime_box.Hide();
            player.healYourself(HP_bar);
            if (hitbox.Bounds.IntersectsWith(Enemy_box1.Bounds))
            {
                player.hit = true;
            }
            else
            {
                player.hit = false;
            }

            gojira_laserBox.Location = new Point(gojiraHead_box.Location.X + 120, gojiraHead_box.Location.Y + 50);
            putin_laser.Location = new Point(putin_box.Location.X + 90, putin_box.Location.Y + 50);


            if (HP_bar.Value <= 0)
            {
                win = false;
                end.Show();
                end.Focus();

                
            }

            if (progressBar1.Value <= 0)
            {
                win = true;
                end.Show();
                end.Focus();
            }

            enemyName_label.Text = ActiveEnemy.EnemyName;

            ai.movement(Enemy_box1, ActiveEnemy, dmg_label, HP_bar);

            dmg_label.ForeColor = Color.Red;
            dmg_label.Text = "" + -progressBar1.Step;
            if (classID == 1)
            {
                player.attack2(enemy1, progressBar1);
            }




            if (progressBar1.Value <= 0)
            {
                win = true;

                end.win = true;
                end.classsvt = classID;
                end.Show();
                end.Focus();
                this.Hide();

                
                
            }

            player.BombX = bombBox.Location.X;
            player.BombY = bombBox.Location.Y;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            player.katana = true;
            player.Bomb = false;
            stratagemBox.Location = new Point(3000, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate();
            if (classID == 1)
            {
                player.attack2(enemy1, progressBar1);
            }



        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sw.Start();
            int whole = 0;
            whole += -progressBar1.Step;
            dmg_label.Text = whole.ToString();
            int a = Convert.ToInt32(sw.ElapsedMilliseconds / 1000);
            if (a == 3)
            {
                dmg_label.Text = " ";
                sw.Restart();
            }

            end.classsvt = classID;
            end.win = this.win;
        }

        private void Enemy_box1_MouseHover(object sender, EventArgs e)
        {
            player.hower = true;

        }

        private void Enemy_box1_MouseLeave(object sender, EventArgs e)
        {
            player.hower = false;
        }

        private void Enemy_box1_MouseDown(object sender, MouseEventArgs e)
        {
            player.downOnBox = true;
        }

        private void Enemy_box1_MouseUp(object sender, MouseEventArgs e)
        {
            player.downOnBox = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            player.katana = false;
            player.Bomb = true;
            player.railgun = false;

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (classID == 2 && player.Bomb)
            {

                stratagemBox.Show();
                player.WalkingHE(ActiveEnemy, progressBar1, bombBox, stratagemBox, Enemy_box1, bombBox2);
            }

        }

        private void Starting_timer_Tick(object sender, EventArgs e)
        {


        }

        private void stratagemBox_Click(object sender, EventArgs e)
        {

        }

        private void healBox_Click(object sender, EventArgs e)
        {
            player.Heal = true;
            stratagemBox.Location = new Point(3000, 0);

        }

        private void timer6_Tick(object sender, EventArgs e)
        {

        }

        private void level1_Aréna_Load(object sender, EventArgs e)
        {
            API api = new API();
            if (classID != 2)
            {
                stratagemBox.Hide();
            }
            
            if (classID != 3)
            {
                nuke_box.Hide();
            }
            
            pictureBox3.Hide();
            pictureBox2.Hide();
            hitbox.Hide();


            name_label.Text = " " + playerName;
            gojira_laserBox.Hide();
            timer5.Start();
            timer3.Start();
            sw.Start();

            if (classID == 1)
            {
                player.katana = true;
                player.bombActivaton = false;
                player.Bomb = false;
            }
            else if (classID == 2)
            {
                player.Heal = false;
                player.railgun = true;
                player.Gojira = false;
                player.katana = false;
                player.hit = false;
                player.PlayerMove = false;
            }
            else if (classID == 3)
            {

            }

            enemies.Add(enemy1);
            enemies.Add(enemy2);
            enemies.Add(enemy3);

            int a = r.Next(1, 4);
            if (a == 1)
            {
                ActiveEnemy.EnemyMaxHP = enemies[0].EnemyMaxHP;
                ActiveEnemy.EnemyBaseDmg = enemies[0].EnemyBaseDmg;
                ActiveEnemy.EnemyName = enemies[0].EnemyName;

                Enemy_box1.SizeMode = PictureBoxSizeMode.StretchImage;
                Enemy_box1.Image = Properties.Resources.a167d6e7514edaa2a9369e495a419942;
                Enemy_box1.Refresh();
                Enemy_box1.Visible = true;
            }
            else if (a == 2)
            {
                ActiveEnemy.EnemyMaxHP = enemies[1].EnemyMaxHP;
                ActiveEnemy.EnemyBaseDmg = enemies[1].EnemyBaseDmg;
                ActiveEnemy.EnemyName = enemies[1].EnemyName;

                Enemy_box1.SizeMode = PictureBoxSizeMode.StretchImage;
                Enemy_box1.Image = Properties.Resources.zeman;
                Enemy_box1.Refresh();
                Enemy_box1.Visible = true;
            }
            else if (a == 3)
            {
                ActiveEnemy.EnemyMaxHP = enemies[2].EnemyMaxHP;
                ActiveEnemy.EnemyBaseDmg = enemies[2].EnemyBaseDmg;
                ActiveEnemy.EnemyName = enemies[2].EnemyName;

                Enemy_box1.SizeMode = PictureBoxSizeMode.StretchImage;
                Enemy_box1.Image = Properties.Resources.krteček;
                Enemy_box1.Refresh();
                Enemy_box1.Visible = true;
            }

            gojiraHead_box.Hide();
            bombBox.Hide();
            bombBox2.Hide();
            pictureBox2.Hide();

            if (classID == 1)
            {
                godzilla_box.Show();
                godzilla_box.Location = new Point(375, 18);
                pictureBox1.Show();
                pictureBox1.Location = new Point(319, 18);

                pictureBox3.Location = new Point(1000, 3);
                railgun_box.Hide();
                railgun_box.Location = new Point(1000, 3);

                putin_box.Hide();
                putin_laser.Hide();
                Ru_basic_box.Hide();
                pictureBox2.Hide();
                

            }
            else if (classID == 2)
            {
                pictureBox3.Show();
                pictureBox3.Location = new Point(375, 18);
                railgun_box.Location = new Point(319, 18);
                railgun_box.Show();

                godzilla_box.Hide();
                godzilla_box.Location = new Point(1000, 3);
                pictureBox1.Hide();
                pictureBox1.Location = new Point(1000, 3);

                putin_box.Hide();
                putin_laser.Hide();

            }
            else if (classID == 3)
            {
                player.katana = false;
                player.Gojira = false;

                player.railgun = false;
                player.railgunShoot = false;
                player.bombActivaton = false;
                player.Bomb = false;

                putin_box.Show();
                nuke_box.Location = new Point(375, 18);
                Ru_basic_box.Location = new Point(319, 18);
                Ru_basic_box.Show();

                gojiraHead_box.Hide();
                godzilla_box.Hide();
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Hide();

                railgun_box.Hide();

                api.end.classsvt = classID;

            }
        }

        private void godzilla_box_Click(object sender, EventArgs e)
        {
            if (classID == 1)
            {
                player.Gojira = true;
            }
        }

        private void railgun_box_Click(object sender, EventArgs e)
        {
            if (classID == 2)
            {
                player.railgun = true;
                player.bombActivaton = false;
                player.Bomb = false;
            }
        }

        private void nuke_box_Click(object sender, EventArgs e)
        {
            if (classID == 3)
            {
                explosion_box.Size = new Size(1037, 570);
                explosion_box.BackgroundImageLayout = ImageLayout.Stretch;
                explosion_box.Image = Properties.Resources.explozion;
                explosion_box.Refresh();
                explosion_box.Show();
                explosion_box.Location = new Point(12, 12);
                Thread.Sleep(1000);

                progressBar1.Step = -progressBar1.Maximum;
                progressBar1.PerformStep();

                
            }
        }

        private void Ru_basic_box_Click(object sender, EventArgs e)
        {
            player.putinSummon = true;
        }
    }
}
