namespace Drawingapp
{
    partial class Form1
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
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            Minimize = new Button();
            Closer = new Button();
            panel2 = new Panel();
            textpassword = new TextBox();
            label3 = new Label();
            MOVETOFORM2 = new Label();
            button1 = new Button();
            label2 = new Label();
            textusername = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(Minimize);
            panel1.Controls.Add(Closer);
            panel1.Font = new Font("Goudy Stout", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1284, 194);
            panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.logo_removebg_preview;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(444, -13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(487, 280);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // Minimize
            // 
            Minimize.BackColor = Color.Transparent;
            Minimize.BackgroundImage = Properties.Resources.line;
            Minimize.BackgroundImageLayout = ImageLayout.Stretch;
            Minimize.FlatAppearance.BorderSize = 0;
            Minimize.FlatStyle = FlatStyle.Flat;
            Minimize.Font = new Font("Mongolian Baiti", 24F);
            Minimize.ImageAlign = ContentAlignment.TopCenter;
            Minimize.Location = new Point(1125, 12);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(59, 57);
            Minimize.TabIndex = 2;
            Minimize.UseVisualStyleBackColor = false;
            Minimize.Click += Minimize_Click;
            // 
            // Closer
            // 
            Closer.BackColor = Color.Transparent;
            Closer.BackgroundImage = Properties.Resources._111;
            Closer.BackgroundImageLayout = ImageLayout.Stretch;
            Closer.FlatAppearance.BorderSize = 0;
            Closer.FlatStyle = FlatStyle.Flat;
            Closer.Font = new Font("Mongolian Baiti", 24F);
            Closer.ImageAlign = ContentAlignment.TopCenter;
            Closer.Location = new Point(1215, 12);
            Closer.Name = "Closer";
            Closer.Size = new Size(59, 57);
            Closer.TabIndex = 1;
            Closer.UseVisualStyleBackColor = false;
            Closer.Click += Closer_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(textpassword);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(MOVETOFORM2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textusername);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(1, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(1284, 728);
            panel2.TabIndex = 1;
            // 
            // textpassword
            // 
            textpassword.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textpassword.Location = new Point(444, 350);
            textpassword.Multiline = true;
            textpassword.Name = "textpassword";
            textpassword.PasswordChar = '*';
            textpassword.Size = new Size(548, 78);
            textpassword.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1050, 496);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 7;
            label3.Text = "label3";
            // 
            // MOVETOFORM2
            // 
            MOVETOFORM2.AutoSize = true;
            MOVETOFORM2.BackColor = Color.Transparent;
            MOVETOFORM2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MOVETOFORM2.ForeColor = SystemColors.ButtonHighlight;
            MOVETOFORM2.Location = new Point(572, 597);
            MOVETOFORM2.Name = "MOVETOFORM2";
            MOVETOFORM2.Size = new Size(316, 29);
            MOVETOFORM2.TabIndex = 6;
            MOVETOFORM2.Text = "Don't have an account? Sign in";
            MOVETOFORM2.Click += MOVETOFORM2_Click;
            MOVETOFORM2.MouseClick += MOVETOFORM2_MouseClick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(218, 103, 32);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Calibri", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(507, 467);
            button1.Name = "button1";
            button1.Size = new Size(447, 83);
            button1.TabIndex = 5;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Calibri", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(507, 36);
            label2.Name = "label2";
            label2.Size = new Size(351, 88);
            label2.TabIndex = 4;
            label2.Text = "User Login";
            // 
            // textusername
            // 
            textusername.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textusername.Location = new Point(444, 176);
            textusername.Multiline = true;
            textusername.Name = "textusername";
            textusername.Size = new Size(548, 78);
            textusername.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.RosyBrown;
            pictureBox2.BackgroundImage = Properties.Resources.password;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(292, 350);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 78);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RosyBrown;
            pictureBox1.BackgroundImage = Properties.Resources.username;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(292, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 78);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1287, 922);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Closer;
        private Button Minimize;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textusername;
        private Label label2;
        private Button button1;
        private Label MOVETOFORM2;
        private Label label3;
        private PictureBox pictureBox3;
        private TextBox textpassword;
    }
}
