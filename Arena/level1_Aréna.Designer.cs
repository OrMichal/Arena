namespace Arena
{
    partial class level1_Aréna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            HP_bar = new ProgressBar();
            panel1 = new Panel();
            putin_laser = new PictureBox();
            putin_box = new PictureBox();
            pictureBox4 = new PictureBox();
            gojira_laserBox = new PictureBox();
            gojiraHead_box = new PictureBox();
            label1 = new Label();
            dmg_label = new Label();
            enemyName_label = new Label();
            progressBar1 = new ProgressBar();
            Enemy_box1 = new PictureBox();
            tester_box = new PictureBox();
            targeter_box = new PictureBox();
            hitbox = new PictureBox();
            pictureBox2 = new PictureBox();
            siime_box = new PictureBox();
            bombBox2 = new PictureBox();
            bombBox = new PictureBox();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            Enemy_Timer = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            pictureBox3 = new PictureBox();
            timer4 = new System.Windows.Forms.Timer(components);
            stratagemBox = new PictureBox();
            timer5 = new System.Windows.Forms.Timer(components);
            Starting_timer = new System.Windows.Forms.Timer(components);
            timer6 = new System.Windows.Forms.Timer(components);
            healBox = new PictureBox();
            lostBox = new PictureBox();
            godzilla_box = new PictureBox();
            railgun_box = new PictureBox();
            name_label = new Label();
            explosion_box = new PictureBox();
            nuke_box = new PictureBox();
            Ru_basic_box = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)putin_laser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)putin_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gojira_laserBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gojiraHead_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enemy_box1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tester_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)targeter_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hitbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)siime_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bombBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bombBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stratagemBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)healBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lostBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)godzilla_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)railgun_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)explosion_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuke_box).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ru_basic_box).BeginInit();
            SuspendLayout();
            // 
            // HP_bar
            // 
            HP_bar.ForeColor = Color.Red;
            HP_bar.Location = new Point(12, 41);
            HP_bar.Maximum = 200;
            HP_bar.Name = "HP_bar";
            HP_bar.Size = new Size(300, 27);
            HP_bar.TabIndex = 1;
            HP_bar.Value = 200;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(putin_laser);
            panel1.Controls.Add(putin_box);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(gojira_laserBox);
            panel1.Controls.Add(gojiraHead_box);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dmg_label);
            panel1.Controls.Add(enemyName_label);
            panel1.Controls.Add(progressBar1);
            panel1.Controls.Add(Enemy_box1);
            panel1.Location = new Point(12, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 570);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // putin_laser
            // 
            putin_laser.BackColor = Color.Firebrick;
            putin_laser.Location = new Point(90, 40);
            putin_laser.Name = "putin_laser";
            putin_laser.Size = new Size(10, 20);
            putin_laser.TabIndex = 22;
            putin_laser.TabStop = false;
            // 
            // putin_box
            // 
            putin_box.BackColor = Color.Transparent;
            putin_box.BackgroundImage = Properties.Resources.putin1;
            putin_box.BackgroundImageLayout = ImageLayout.Stretch;
            putin_box.Location = new Point(0, 0);
            putin_box.Name = "putin_box";
            putin_box.Size = new Size(100, 100);
            putin_box.TabIndex = 21;
            putin_box.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(1027, -3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(10, 570);
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // gojira_laserBox
            // 
            gojira_laserBox.Anchor = AnchorStyles.Left;
            gojira_laserBox.BackColor = Color.Transparent;
            gojira_laserBox.BackgroundImage = Properties.Resources.gojira_fire;
            gojira_laserBox.BackgroundImageLayout = ImageLayout.Stretch;
            gojira_laserBox.Location = new Point(106, 223);
            gojira_laserBox.Name = "gojira_laserBox";
            gojira_laserBox.Size = new Size(20, 20);
            gojira_laserBox.TabIndex = 17;
            gojira_laserBox.TabStop = false;
            // 
            // gojiraHead_box
            // 
            gojiraHead_box.BackColor = Color.Transparent;
            gojiraHead_box.BackgroundImage = Properties.Resources.gojira2;
            gojiraHead_box.BackgroundImageLayout = ImageLayout.Stretch;
            gojiraHead_box.Location = new Point(0, 181);
            gojiraHead_box.Name = "gojiraHead_box";
            gojiraHead_box.Size = new Size(100, 100);
            gojiraHead_box.TabIndex = 14;
            gojiraHead_box.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(810, 529);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // dmg_label
            // 
            dmg_label.AutoSize = true;
            dmg_label.Location = new Point(510, 121);
            dmg_label.Name = "dmg_label";
            dmg_label.Size = new Size(10, 15);
            dmg_label.TabIndex = 3;
            dmg_label.Text = " ";
            // 
            // enemyName_label
            // 
            enemyName_label.AutoSize = true;
            enemyName_label.Font = new Font("Microsoft Sans Serif", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
            enemyName_label.Location = new Point(148, 519);
            enemyName_label.Name = "enemyName_label";
            enemyName_label.Size = new Size(71, 20);
            enemyName_label.TabIndex = 2;
            enemyName_label.Text = " Enemy";
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Maroon;
            progressBar1.Location = new Point(149, 547);
            progressBar1.Maximum = 400000;
            progressBar1.Name = "progressBar1";
            progressBar1.RightToLeft = RightToLeft.No;
            progressBar1.RightToLeftLayout = true;
            progressBar1.Size = new Size(700, 20);
            progressBar1.Step = -1;
            progressBar1.TabIndex = 1;
            progressBar1.Value = 400000;
            // 
            // Enemy_box1
            // 
            Enemy_box1.BackgroundImage = Properties.Resources.a167d6e7514edaa2a9369e495a419942;
            Enemy_box1.BackgroundImageLayout = ImageLayout.Stretch;
            Enemy_box1.Location = new Point(443, 155);
            Enemy_box1.Name = "Enemy_box1";
            Enemy_box1.Size = new Size(100, 100);
            Enemy_box1.TabIndex = 0;
            Enemy_box1.TabStop = false;
            Enemy_box1.MouseDown += Enemy_box1_MouseDown;
            Enemy_box1.MouseLeave += Enemy_box1_MouseLeave;
            Enemy_box1.MouseHover += Enemy_box1_MouseHover;
            Enemy_box1.MouseUp += Enemy_box1_MouseUp;
            // 
            // tester_box
            // 
            tester_box.Location = new Point(1606, 242);
            tester_box.Name = "tester_box";
            tester_box.Size = new Size(10, 10);
            tester_box.TabIndex = 20;
            tester_box.TabStop = false;
            // 
            // targeter_box
            // 
            targeter_box.BackColor = Color.Transparent;
            targeter_box.Location = new Point(1606, 271);
            targeter_box.Name = "targeter_box";
            targeter_box.Size = new Size(10, 10);
            targeter_box.TabIndex = 19;
            targeter_box.TabStop = false;
            // 
            // hitbox
            // 
            hitbox.BackColor = Color.Transparent;
            hitbox.Location = new Point(1654, 157);
            hitbox.Name = "hitbox";
            hitbox.Size = new Size(10, 10);
            hitbox.TabIndex = 10;
            hitbox.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(192, 0, 0);
            pictureBox2.Location = new Point(1419, 288);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(10, 10);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // siime_box
            // 
            siime_box.BackgroundImage = Properties.Resources.bg_f8f8f8_flat_750x_075_f_pad_750x1000_f8f8f8;
            siime_box.BackgroundImageLayout = ImageLayout.Stretch;
            siime_box.Location = new Point(1654, 15);
            siime_box.Name = "siime_box";
            siime_box.Size = new Size(986, 669);
            siime_box.TabIndex = 10;
            siime_box.TabStop = false;
            // 
            // bombBox2
            // 
            bombBox2.BackColor = Color.White;
            bombBox2.BackgroundImageLayout = ImageLayout.Stretch;
            bombBox2.Image = Properties.Resources.booom;
            bombBox2.Location = new Point(1524, 37);
            bombBox2.Name = "bombBox2";
            bombBox2.Size = new Size(169, 214);
            bombBox2.TabIndex = 12;
            bombBox2.TabStop = false;
            // 
            // bombBox
            // 
            bombBox.BackColor = Color.White;
            bombBox.BackgroundImageLayout = ImageLayout.Stretch;
            bombBox.Image = Properties.Resources.booom;
            bombBox.Location = new Point(1524, 288);
            bombBox.Name = "bombBox";
            bombBox.Size = new Size(169, 214);
            bombBox.TabIndex = 11;
            bombBox.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Maroon;
            pictureBox1.BackgroundImage = Properties.Resources._1000_F_389968611_wW1hheiYzGK9XUqKsPoIOAlBYQZswv7i;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(319, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // Enemy_Timer
            // 
            Enemy_Timer.Interval = 50;
            Enemy_Timer.Tick += Enemy_Timer_Tick;
            // 
            // button1
            // 
            button1.Location = new Point(1177, 646);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "konec hry";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer2
            // 
            timer2.Interval = 150;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            timer3.Tick += timer3_Tick;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.images;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(375, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // timer4
            // 
            timer4.Interval = 600000;
            timer4.Tick += timer4_Tick;
            // 
            // stratagemBox
            // 
            stratagemBox.BackColor = Color.Transparent;
            stratagemBox.BackgroundImage = Properties.Resources.crosshai;
            stratagemBox.BackgroundImageLayout = ImageLayout.Stretch;
            stratagemBox.InitialImage = null;
            stratagemBox.Location = new Point(415, 18);
            stratagemBox.Name = "stratagemBox";
            stratagemBox.Size = new Size(10, 10);
            stratagemBox.TabIndex = 12;
            stratagemBox.TabStop = false;
            stratagemBox.Click += stratagemBox_Click;
            // 
            // timer5
            // 
            timer5.Interval = 1800;
            timer5.Tick += timer5_Tick;
            // 
            // Starting_timer
            // 
            Starting_timer.Interval = 2;
            Starting_timer.Tick += Starting_timer_Tick;
            // 
            // timer6
            // 
            timer6.Interval = 1000;
            timer6.Tick += timer6_Tick;
            // 
            // healBox
            // 
            healBox.BackgroundImage = Properties.Resources.artworks_sR27lRr5AuhCROr9_bjjv4Q_t500x500;
            healBox.BackgroundImageLayout = ImageLayout.Stretch;
            healBox.Location = new Point(431, 18);
            healBox.Name = "healBox";
            healBox.Size = new Size(50, 50);
            healBox.TabIndex = 13;
            healBox.TabStop = false;
            healBox.Click += healBox_Click;
            // 
            // lostBox
            // 
            lostBox.BackgroundImage = Properties.Resources.social_credit_system_china_social_credit;
            lostBox.BackgroundImageLayout = ImageLayout.Stretch;
            lostBox.Location = new Point(1452, 58);
            lostBox.Name = "lostBox";
            lostBox.Size = new Size(1037, 570);
            lostBox.TabIndex = 11;
            lostBox.TabStop = false;
            // 
            // godzilla_box
            // 
            godzilla_box.BackColor = Color.Transparent;
            godzilla_box.BackgroundImage = Properties.Resources.godzilla;
            godzilla_box.BackgroundImageLayout = ImageLayout.Stretch;
            godzilla_box.Location = new Point(1116, 84);
            godzilla_box.Name = "godzilla_box";
            godzilla_box.Size = new Size(50, 50);
            godzilla_box.TabIndex = 15;
            godzilla_box.TabStop = false;
            godzilla_box.Click += godzilla_box_Click;
            // 
            // railgun_box
            // 
            railgun_box.BackColor = Color.WhiteSmoke;
            railgun_box.BackgroundImage = Properties.Resources.Výstřižek;
            railgun_box.BackgroundImageLayout = ImageLayout.Stretch;
            railgun_box.Location = new Point(1159, 239);
            railgun_box.Name = "railgun_box";
            railgun_box.Size = new Size(50, 50);
            railgun_box.TabIndex = 16;
            railgun_box.TabStop = false;
            railgun_box.Click += railgun_box_Click;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Snap ITC", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name_label.ForeColor = SystemColors.ControlLightLight;
            name_label.Location = new Point(12, 15);
            name_label.Name = "name_label";
            name_label.Size = new Size(42, 23);
            name_label.TabIndex = 17;
            name_label.Text = "you";
            // 
            // explosion_box
            // 
            explosion_box.BackColor = Color.Transparent;
            explosion_box.BackgroundImage = Properties.Resources.explozion;
            explosion_box.BackgroundImageLayout = ImageLayout.Stretch;
            explosion_box.Location = new Point(1643, 374);
            explosion_box.Name = "explosion_box";
            explosion_box.Size = new Size(89, 76);
            explosion_box.TabIndex = 23;
            explosion_box.TabStop = false;
            // 
            // nuke_box
            // 
            nuke_box.BackColor = Color.Transparent;
            nuke_box.BackgroundImage = Properties.Resources.images1;
            nuke_box.BackgroundImageLayout = ImageLayout.Stretch;
            nuke_box.Location = new Point(1096, 400);
            nuke_box.Name = "nuke_box";
            nuke_box.Size = new Size(50, 50);
            nuke_box.TabIndex = 23;
            nuke_box.TabStop = false;
            nuke_box.Click += nuke_box_Click;
            // 
            // Ru_basic_box
            // 
            Ru_basic_box.BackColor = Color.Transparent;
            Ru_basic_box.BackgroundImage = Properties.Resources.images__1_;
            Ru_basic_box.BackgroundImageLayout = ImageLayout.Stretch;
            Ru_basic_box.Location = new Point(1354, 441);
            Ru_basic_box.Name = "Ru_basic_box";
            Ru_basic_box.Size = new Size(50, 50);
            Ru_basic_box.TabIndex = 23;
            Ru_basic_box.TabStop = false;
            Ru_basic_box.Click += Ru_basic_box_Click;
            // 
            // level1_Aréna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1264, 681);
            Controls.Add(Ru_basic_box);
            Controls.Add(nuke_box);
            Controls.Add(explosion_box);
            Controls.Add(tester_box);
            Controls.Add(name_label);
            Controls.Add(targeter_box);
            Controls.Add(railgun_box);
            Controls.Add(godzilla_box);
            Controls.Add(siime_box);
            Controls.Add(lostBox);
            Controls.Add(hitbox);
            Controls.Add(healBox);
            Controls.Add(pictureBox2);
            Controls.Add(bombBox);
            Controls.Add(bombBox2);
            Controls.Add(stratagemBox);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(HP_bar);
            Name = "level1_Aréna";
            Text = "level1_Aréna";
            Load += level1_Aréna_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)putin_laser).EndInit();
            ((System.ComponentModel.ISupportInitialize)putin_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)gojira_laserBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)gojiraHead_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enemy_box1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tester_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)targeter_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)hitbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)siime_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)bombBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)bombBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)stratagemBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)healBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)lostBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)godzilla_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)railgun_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)explosion_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuke_box).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ru_basic_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player_box;
        private ProgressBar HP_bar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer Enemy_Timer;
        private PictureBox Enemy_box1;
        private Button button1;
        private System.Windows.Forms.Timer timer2;
        private Label enemyName_label;
        private ProgressBar progressBar1;
        private Label dmg_label;
        private Label label1;
        private System.Windows.Forms.Timer timer3;
        private PictureBox pictureBox2;
        private PictureBox siime_box;
        private PictureBox bombBox;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer4;
        private PictureBox stratagemBox;
        private System.Windows.Forms.Timer timer5;
        private PictureBox bombBox2;
        private System.Windows.Forms.Timer Starting_timer;
        private System.Windows.Forms.Timer timer6;
        private PictureBox healBox;
        private PictureBox lostBox;
        private PictureBox hitbox;
        private PictureBox gojiraHead_box;
        private PictureBox godzilla_box;
        private PictureBox railgun_box;
        private PictureBox gojira_laserBox;
        private PictureBox pictureBox4;
        private PictureBox targeter_box;
        private Label name_label;
        private PictureBox tester_box;
        private PictureBox putin_box;
        private PictureBox putin_laser;
        private PictureBox explosion_box;
        private PictureBox nuke_box;
        private PictureBox Ru_basic_box;
    }
}