namespace Arena
{
    partial class settings
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
            Name_label = new Label();
            Name_textBox = new TextBox();
            class_label = new Label();
            japanese_button = new Button();
            American_button = new Button();
            start_button = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            apply_button = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Font = new Font("Snap ITC", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name_label.Location = new Point(28, 32);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(69, 23);
            Name_label.TabIndex = 0;
            Name_label.Text = "Name:";
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(28, 58);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(158, 23);
            Name_textBox.TabIndex = 1;
            // 
            // class_label
            // 
            class_label.AutoSize = true;
            class_label.Font = new Font("Snap ITC", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            class_label.Location = new Point(29, 108);
            class_label.Name = "class_label";
            class_label.Size = new Size(68, 23);
            class_label.TabIndex = 2;
            class_label.Text = "Class:";
            // 
            // japanese_button
            // 
            japanese_button.Location = new Point(29, 134);
            japanese_button.Name = "japanese_button";
            japanese_button.Size = new Size(75, 23);
            japanese_button.TabIndex = 3;
            japanese_button.Text = "Japanese";
            japanese_button.UseVisualStyleBackColor = true;
            japanese_button.Click += japanese_button_Click;
            // 
            // American_button
            // 
            American_button.Location = new Point(110, 135);
            American_button.Name = "American_button";
            American_button.Size = new Size(76, 21);
            American_button.TabIndex = 4;
            American_button.Text = "American";
            American_button.UseVisualStyleBackColor = true;
            American_button.Click += American_button_Click;
            // 
            // start_button
            // 
            start_button.Location = new Point(68, 202);
            start_button.Name = "start_button";
            start_button.Size = new Size(75, 23);
            start_button.TabIndex = 5;
            start_button.Text = "Start";
            start_button.UseVisualStyleBackColor = true;
            start_button.Click += start_button_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // apply_button
            // 
            apply_button.Location = new Point(123, 87);
            apply_button.Name = "apply_button";
            apply_button.Size = new Size(63, 23);
            apply_button.TabIndex = 6;
            apply_button.Text = "apply";
            apply_button.UseVisualStyleBackColor = true;
            apply_button.Click += apply_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 258);
            Controls.Add(label1);
            Controls.Add(apply_button);
            Controls.Add(start_button);
            Controls.Add(American_button);
            Controls.Add(japanese_button);
            Controls.Add(class_label);
            Controls.Add(Name_textBox);
            Controls.Add(Name_label);
            Name = "settings";
            Text = "settings";
            Load += settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name_label;
        private TextBox Name_textBox;
        private Label class_label;
        private Button japanese_button;
        private Button American_button;
        private Button start_button;
        private System.Windows.Forms.Timer timer1;
        private Button apply_button;
        private Label label1;
    }
}