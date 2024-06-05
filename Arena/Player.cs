using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    internal class Player
    {
        public string Name { get; set; }
        public int ClassID;
        public int MaxHp = 200;
        public int Hp = 200;
        public int Mana = 100;
        public int Armor = 20;
        public int PlayerDmg = 5;
        public bool katana = false;
        public bool Bomb = false;
        public int finaldmg = 20;
        Random r = new Random();

        public int manaProcento;
        public int hpProcento;

        public int meißLokatonX = 200;
        public int meißlokatonY = 200;

        public Graphics g;
        public Pen pen;

        public bool hit;
        public bool mouseHold;
        public bool PlayerMove;
        public bool hower;
        public bool downOnBox;
        public bool pressed;
        public bool pressed2;

        public int BombX;
        public int BombY;

        public bool bombActivaton;
        public bool Heal;
        public bool Gojira = false;
        public bool railgun = false;
        public bool railgunShoot = false;

        public bool putinSummon = false;

        public void attack(MouseEventArgs e, Enemy enemy)
        {
            pen = new Pen(Color.Black, 5);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;

            if (PlayerMove && meißLokatonX != -1 && meißlokatonY != -1)
            {
                
                g.DrawLine(pen, new Point(meißLokatonX, meißlokatonY), e.Location);
                meißLokatonX = e.X;
                meißlokatonY = e.Y;

            }

        }

        public void attack2(Enemy enemy, ProgressBar pbar)
        {


            if (hit && PlayerMove && mouseHold || meißLokatonX == enemy.EnemyX && meißlokatonY == enemy.EnemyY)
            {
                finaldmg = (r.Next(3, 8) + PlayerDmg)*100;
                
                pbar.Step = -finaldmg;
                pbar.PerformStep();
                

            }

            
        }

        public void WalkingHE(Enemy enemy, ProgressBar pbar, PictureBox pb, PictureBox stratagem, PictureBox enem, PictureBox pb2)
        {
            

            pb.Location = new Point(stratagem.Location.X - 100 + r.Next(-300, 300), r.Next(90, 300));
            pb.Show();

            pb2.Location = new Point(stratagem.Location.X - 100 + r.Next(-300, 300), r.Next(90, 300));
            pb2.Show();
            if (pb.Bounds.IntersectsWith(enem.Bounds))
            {
                pbar.Step -= 1000;
                pbar.PerformStep();
            }

            if (pb2.Bounds.IntersectsWith(enem.Bounds))
            {
                pbar.Step -= 1000;
                pbar.PerformStep();
            }


        }

        public void healYourself(ProgressBar playerHpbar)
        {
            if (Heal)
            {
                playerHpbar.Step = r.Next(20, 90);
                playerHpbar.PerformStep();
                Heal = false;
            }
            
        }

        public void GojiraAttack(ProgressBar enemyBar, PictureBox gojirabox, PictureBox enemyBox, PictureBox laser, PictureBox bound, int speed)
        {
            gojirabox.Location = new Point(12, enemyBox.Location.Y);
            if (laser.Bounds.IntersectsWith(bound.Bounds))
            {
                laser.Size = new Size(20, 4);
            }
            else
            {
                laser.Size = new Size(laser.Size.Width + speed, 4);
            }

            if (laser.Bounds.IntersectsWith(enemyBox.Bounds))
            {
                enemyBar.Step = -500;
                enemyBar.PerformStep();
            }
        }

        public void railGunAttack(ProgressBar enemyBar, PictureBox enemyBox, PictureBox targeter, PictureBox testerBox)
        {
            pen.Width = 9;
            pen.Color = Color.Blue;

            int zacatekX = 500;
            int zacateY = 20;


            if (this.railgunShoot)
            {
                g.DrawLine(pen, new Point(zacatekX, zacateY), new Point(enemyBox.Location.X + 50, enemyBox.Location.Y + 50));


                enemyBar.Step = -100;
                enemyBar.PerformStep();
                
            }

            this.railgunShoot = false;

        }


    }
}
