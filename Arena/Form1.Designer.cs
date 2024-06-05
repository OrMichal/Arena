namespace Arena
{
    partial class Aréna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            end_button = new Button();
            label1 = new Label();
            name_label = new Label();
            american_button = new Button();
            japanese_button = new Button();
            textBox1 = new TextBox();
            class_label = new Label();
            apply_button = new Button();
            Russian_button = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Snap ITC", 30F);
            button1.Location = new Point(63, 233);
            button1.Name = "button1";
            button1.Size = new Size(208, 79);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // end_button
            // 
            end_button.Font = new Font("Snap ITC", 30F);
            end_button.Location = new Point(63, 356);
            end_button.Name = "end_button";
            end_button.Size = new Size(208, 79);
            end_button.TabIndex = 1;
            end_button.Text = "Quit";
            end_button.UseVisualStyleBackColor = true;
            end_button.Click += end_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 70.25F);
            label1.Location = new Point(36, 44);
            label1.Name = "label1";
            label1.Size = new Size(364, 122);
            label1.TabIndex = 2;
            label1.Text = "Aréna";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Snap ITC", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name_label.Location = new Point(317, 233);
            name_label.Name = "name_label";
            name_label.Size = new Size(69, 23);
            name_label.TabIndex = 3;
            name_label.Text = "Name:";
            // 
            // american_button
            // 
            american_button.Location = new Point(388, 358);
            american_button.Name = "american_button";
            american_button.Size = new Size(71, 31);
            american_button.TabIndex = 4;
            american_button.Text = "American";
            american_button.UseVisualStyleBackColor = true;
            american_button.Click += american_button_Click;
            // 
            // japanese_button
            // 
            japanese_button.Location = new Point(317, 358);
            japanese_button.Name = "japanese_button";
            japanese_button.Size = new Size(65, 31);
            japanese_button.TabIndex = 6;
            japanese_button.Text = "Japanese";
            japanese_button.UseVisualStyleBackColor = true;
            japanese_button.Click += japanese_button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 259);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 7;
            // 
            // class_label
            // 
            class_label.AutoSize = true;
            class_label.Font = new Font("Snap ITC", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            class_label.Location = new Point(317, 332);
            class_label.Name = "class_label";
            class_label.Size = new Size(68, 23);
            class_label.TabIndex = 8;
            class_label.Text = "Class:";
            // 
            // apply_button
            // 
            apply_button.Location = new Point(415, 443);
            apply_button.Name = "apply_button";
            apply_button.Size = new Size(44, 23);
            apply_button.TabIndex = 9;
            apply_button.Text = "apply";
            apply_button.UseVisualStyleBackColor = true;
            apply_button.Click += apply_button_Click;
            // 
            // Russian_button
            // 
            Russian_button.Location = new Point(317, 390);
            Russian_button.Name = "Russian_button";
            Russian_button.Size = new Size(65, 31);
            Russian_button.TabIndex = 10;
            Russian_button.Text = "Russian";
            Russian_button.UseVisualStyleBackColor = true;
            Russian_button.Click += Russian_button_Click;
            // 
            // Aréna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maxresdefault;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 561);
            Controls.Add(Russian_button);
            Controls.Add(apply_button);
            Controls.Add(class_label);
            Controls.Add(textBox1);
            Controls.Add(japanese_button);
            Controls.Add(american_button);
            Controls.Add(name_label);
            Controls.Add(label1);
            Controls.Add(end_button);
            Controls.Add(button1);
            Name = "Aréna";
            Text = "Aréna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button end_button;
        private Label label1;
        private Label name_label;
        private Button button2;
        private Button button3;
        private Button japanese_button;
        private Button american_button;
        private TextBox textBox1;
        private Label class_label;
        private Button apply_button;
        private Button Russian_button;
    }
}
