namespace Arena
{
    partial class Set
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
            Name_textBox = new TextBox();
            Name_label = new Label();
            Class_label = new Label();
            start_button = new Button();
            japanese_button = new Button();
            american_button = new Button();
            SuspendLayout();
            // 
            // Name_textBox
            // 
            Name_textBox.Location = new Point(12, 37);
            Name_textBox.Name = "Name_textBox";
            Name_textBox.Size = new Size(157, 23);
            Name_textBox.TabIndex = 0;
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Font = new Font("Snap ITC", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name_label.Location = new Point(12, 9);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(69, 23);
            Name_label.TabIndex = 1;
            Name_label.Text = "Name:";
            // 
            // Class_label
            // 
            Class_label.AutoSize = true;
            Class_label.Font = new Font("Snap ITC", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Class_label.Location = new Point(13, 81);
            Class_label.Name = "Class_label";
            Class_label.Size = new Size(68, 23);
            Class_label.TabIndex = 3;
            Class_label.Text = "Class:";
            // 
            // start_button
            // 
            start_button.Font = new Font("Snap ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start_button.Location = new Point(37, 146);
            start_button.Name = "start_button";
            start_button.Size = new Size(87, 33);
            start_button.TabIndex = 4;
            start_button.Text = "Play";
            start_button.UseVisualStyleBackColor = true;
            start_button.Click += start_button_Click;
            // 
            // japanese_button
            // 
            japanese_button.Location = new Point(13, 107);
            japanese_button.Name = "japanese_button";
            japanese_button.Size = new Size(75, 23);
            japanese_button.TabIndex = 5;
            japanese_button.Text = "Japanese";
            japanese_button.UseVisualStyleBackColor = true;
            japanese_button.Click += japanese_button_Click;
            // 
            // american_button
            // 
            american_button.Location = new Point(94, 107);
            american_button.Name = "american_button";
            american_button.Size = new Size(75, 23);
            american_button.TabIndex = 6;
            american_button.Text = "American";
            american_button.UseVisualStyleBackColor = true;
            american_button.Click += american_button_Click;
            // 
            // Set
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 203);
            Controls.Add(american_button);
            Controls.Add(japanese_button);
            Controls.Add(start_button);
            Controls.Add(Class_label);
            Controls.Add(Name_label);
            Controls.Add(Name_textBox);
            Name = "Set";
            Text = "Set";
            Load += Set_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Name_textBox;
        private Label Name_label;
        private Label Class_label;
        private Button start_button;
        private Button japanese_button;
        private Button american_button;
    }
}