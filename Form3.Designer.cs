namespace Drawingapp
{
    partial class Form3
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
            panel1 = new Panel();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonback = new Button();
            Minimize3 = new Button();
            Closer3 = new Button();
            label1 = new Label();
            buttonstart = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(buttonback);
            panel1.Controls.Add(Minimize3);
            panel1.Controls.Add(Closer3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonstart);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1415, 893);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Jokerman", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Peru;
            label2.Location = new Point(474, 474);
            label2.Name = "label2";
            label2.Size = new Size(476, 58);
            label2.TabIndex = 11;
            label2.Text = "Sketch, Create, Inspire";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources._555;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(976, 266);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(436, 627);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources._222;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(0, 266);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(425, 627);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // buttonback
            // 
            buttonback.BackColor = Color.MistyRose;
            buttonback.FlatAppearance.BorderSize = 0;
            buttonback.FlatStyle = FlatStyle.Flat;
            buttonback.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonback.Location = new Point(558, 720);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(331, 56);
            buttonback.TabIndex = 8;
            buttonback.Text = "Back";
            buttonback.UseVisualStyleBackColor = false;
            buttonback.Click += buttonback_Click;
            // 
            // Minimize3
            // 
            Minimize3.BackColor = Color.Black;
            Minimize3.BackgroundImage = Properties.Resources.line;
            Minimize3.BackgroundImageLayout = ImageLayout.Stretch;
            Minimize3.FlatAppearance.BorderSize = 0;
            Minimize3.FlatStyle = FlatStyle.Flat;
            Minimize3.Font = new Font("Mongolian Baiti", 24F);
            Minimize3.ImageAlign = ContentAlignment.TopCenter;
            Minimize3.Location = new Point(1248, 13);
            Minimize3.Name = "Minimize3";
            Minimize3.Size = new Size(55, 57);
            Minimize3.TabIndex = 4;
            Minimize3.UseVisualStyleBackColor = false;
            Minimize3.Click += Minimize3_Click;
            // 
            // Closer3
            // 
            Closer3.BackColor = Color.Black;
            Closer3.BackgroundImage = Properties.Resources._111;
            Closer3.BackgroundImageLayout = ImageLayout.Stretch;
            Closer3.FlatAppearance.BorderSize = 0;
            Closer3.FlatStyle = FlatStyle.Flat;
            Closer3.Font = new Font("Mongolian Baiti", 24F);
            Closer3.ImageAlign = ContentAlignment.TopCenter;
            Closer3.Location = new Point(1332, 13);
            Closer3.Name = "Closer3";
            Closer3.Size = new Size(59, 57);
            Closer3.TabIndex = 3;
            Closer3.UseVisualStyleBackColor = false;
            Closer3.Click += Closer3_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Black;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1415, 96);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // buttonstart
            // 
            buttonstart.BackColor = Color.MistyRose;
            buttonstart.FlatAppearance.BorderSize = 0;
            buttonstart.FlatStyle = FlatStyle.Flat;
            buttonstart.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonstart.Location = new Point(558, 635);
            buttonstart.Name = "buttonstart";
            buttonstart.Size = new Size(331, 56);
            buttonstart.TabIndex = 6;
            buttonstart.Text = "Start";
            buttonstart.UseVisualStyleBackColor = false;
            buttonstart.Click += buttonstart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.logo_app;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(343, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(690, 566);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 894);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Minimize3;
        private Button Closer3;
        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonstart;
        private Button buttonback;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
    }
}