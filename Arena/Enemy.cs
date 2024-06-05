using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena
{
    internal class Enemy
    {
        
        Player player = new Player();
        Random r = new Random();
        public string EnemyName { get; set; }
        public int EnemyMaxHP { get; set; }
        public int EnemyHP;
        public int EnemyBaseDmg { get; set; }
        public int EnemyFinalDmg;
        public int enemyHPProcento;
        public int EnemyX;
        public int EnemyY;

        public Enemy(int EnemyMaxHP, int EnemyBaseDmg, string EnemyName)
        {
            this.EnemyMaxHP = EnemyMaxHP;
            this.EnemyBaseDmg = EnemyBaseDmg;
            this.EnemyName = EnemyName;
        }

        public void Attack(Enemy enemy, ProgressBar pHp)
        {
            
            EnemyFinalDmg = EnemyBaseDmg + r.Next(10, 20) - player.Armor / 5;
            pHp.Step = -EnemyFinalDmg / 30;
            pHp.PerformStep();
        }

        
    }
}
