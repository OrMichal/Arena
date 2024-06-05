using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arena
{
    internal class Ai
    {
        public Random r = new Random();
        public void movement(PictureBox Enemy_box1, Enemy ActiveEnemy, Label dmg_label, ProgressBar HP_bar)
        {
            int i = r.Next(5, 10);
            if (i == 6)
            {
                if (Enemy_box1.Location.X < 500)
                {
                    Enemy_box1.Location = new Point(ActiveEnemy.EnemyX += 20, ActiveEnemy.EnemyY);
                    dmg_label.Location = new Point(ActiveEnemy.EnemyX + 10, ActiveEnemy.EnemyY - 80);
                }
                else
                {
                    Enemy_box1.Location = new Point(ActiveEnemy.EnemyX -= 20, ActiveEnemy.EnemyY);
                    dmg_label.Location = new Point(ActiveEnemy.EnemyX + 10, ActiveEnemy.EnemyY - 40);
                }

            }
            else if (i == 5)
            {
                if (Enemy_box1.Location.Y < 300)
                {
                    Enemy_box1.Location = new Point(ActiveEnemy.EnemyX, ActiveEnemy.EnemyY += 20);
                    dmg_label.Location = new Point(ActiveEnemy.EnemyX + 10, ActiveEnemy.EnemyY - 40);
                }
                else
                {
                    Enemy_box1.Location = new Point(ActiveEnemy.EnemyX, ActiveEnemy.EnemyY -= 20);
                    dmg_label.Location = new Point(ActiveEnemy.EnemyX + 10, ActiveEnemy.EnemyY - 40);
                }


            }
            else if (i == 7)
            {
                if (Enemy_box1.Location.X > 500)
                {
                    Enemy_box1.Location = new Point(ActiveEnemy.EnemyX -= 20, ActiveEnemy.EnemyY);
                    dmg_label.Location = new Point(ActiveEnemy.EnemyX + 10, ActiveEnemy.EnemyY - 40);
                }
                else
                {

                    Enemy_box1.Location = new Point(ActiveEnemy.EnemyX += 20, ActiveEnemy.EnemyY);
                    dmg_label.Location = new Point(ActiveEnemy.EnemyX + 10, ActiveEnemy.EnemyY - 40);
                }

            }
            else if (i == 9)
            {
                ActiveEnemy.Attack(ActiveEnemy, HP_bar);
            }
            else
            {
                if (Enemy_box1.Location.Y > 300)
                {
                    Enemy_box1.Location = new Point(ActiveEnemy.EnemyX, ActiveEnemy.EnemyY -= 20);
                    dmg_label.Location = new Point(ActiveEnemy.EnemyX + 10, ActiveEnemy.EnemyY - 40);
                }
                else
                {
                    Enemy_box1.Location = new Point(ActiveEnemy.EnemyX, ActiveEnemy.EnemyY += 20);
                    dmg_label.Location = new Point(ActiveEnemy.EnemyX + 10, ActiveEnemy.EnemyY - 40);
                }


            }
        }
    }
}
