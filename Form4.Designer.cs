namespace Drawingapp
{
    partial class Form4
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
            btn_save = new Button();
            btn_clear = new Button();
            color_picker = new PictureBox();
            pic_color = new Button();
            panel3 = new Panel();
            btn_fill = new Button();
            btn_line = new Button();
            btn_rect = new Button();
            btn_ellipse = new Button();
            btn_color = new Button();
            btn_pencil = new Button();
            btn_eraser = new Button();
            panel2 = new Panel();
            pic = new PictureBox();
            Closer4 = new Button();
            Minimize4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(Minimize4);
            panel1.Controls.Add(Closer4);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(btn_clear);
            panel1.Controls.Add(color_picker);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1641, 186);
            panel1.TabIndex = 0;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Transparent;
            btn_save.BackgroundImageLayout = ImageLayout.Center;
            btn_save.FlatAppearance.BorderColor = Color.White;
            btn_save.FlatAppearance.BorderSize = 2;
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 69, 0);
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_save.ForeColor = SystemColors.ButtonHighlight;
            btn_save.ImageAlign = ContentAlignment.TopCenter;
            btn_save.Location = new Point(1403, 37);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(124, 49);
            btn_save.TabIndex = 10;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Transparent;
            btn_clear.BackgroundImageLayout = ImageLayout.Center;
            btn_clear.FlatAppearance.BorderColor = Color.White;
            btn_clear.FlatAppearance.BorderSize = 2;
            btn_clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 69, 0);
            btn_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = SystemColors.ButtonHighlight;
            btn_clear.ImageAlign = ContentAlignment.TopCenter;
            btn_clear.Location = new Point(1403, 92);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(124, 49);
            btn_clear.TabIndex = 7;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // color_picker
            // 
            color_picker.BackgroundImage = Properties.Resources.color_palette;
            color_picker.BackgroundImageLayout = ImageLayout.Stretch;
            color_picker.Cursor = Cursors.Hand;
            color_picker.Location = new Point(0, 12);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(506, 168);
            color_picker.TabIndex = 9;
            color_picker.TabStop = false;
            color_picker.MouseClick += color_picker_MouseClick;
            // 
            // pic_color
            // 
            pic_color.Location = new Point(512, 52);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(75, 74);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaptionText;
            panel3.Controls.Add(btn_fill);
            panel3.Controls.Add(btn_line);
            panel3.Controls.Add(btn_rect);
            panel3.Controls.Add(btn_ellipse);
            panel3.Controls.Add(btn_color);
            panel3.Controls.Add(btn_pencil);
            panel3.Controls.Add(btn_eraser);
            panel3.Location = new Point(593, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(795, 131);
            panel3.TabIndex = 8;
            // 
            // btn_fill
            // 
            btn_fill.BackColor = Color.Transparent;
            btn_fill.BackgroundImageLayout = ImageLayout.Stretch;
            btn_fill.Cursor = Cursors.Hand;
            btn_fill.FlatAppearance.BorderColor = Color.Red;
            btn_fill.FlatAppearance.BorderSize = 2;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 69, 0);
            btn_fill.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.ForeColor = SystemColors.ButtonHighlight;
            btn_fill.Image = Properties.Resources.bucket;
            btn_fill.ImageAlign = ContentAlignment.TopCenter;
            btn_fill.Location = new Point(125, 29);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(85, 74);
            btn_fill.TabIndex = 2;
            btn_fill.Text = "Fill";
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = false;
            btn_fill.Click += btn_fill_Click;
            // 
            // btn_line
            // 
            btn_line.BackColor = Color.Transparent;
            btn_line.BackgroundImageLayout = ImageLayout.Stretch;
            btn_line.Cursor = Cursors.Hand;
            btn_line.FlatAppearance.BorderColor = Color.Red;
            btn_line.FlatAppearance.BorderSize = 2;
            btn_line.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 69, 0);
            btn_line.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.ForeColor = SystemColors.ButtonHighlight;
            btn_line.Image = Properties.Resources.line1;
            btn_line.ImageAlign = ContentAlignment.TopCenter;
            btn_line.Location = new Point(460, 29);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(85, 74);
            btn_line.TabIndex = 7;
            btn_line.Text = "Line";
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.UseVisualStyleBackColor = false;
            btn_line.Click += btn_line_Click;
            // 
            // btn_rect
            // 
            btn_rect.BackColor = Color.Transparent;
            btn_rect.BackgroundImageLayout = ImageLayout.Center;
            btn_rect.Cursor = Cursors.Hand;
            btn_rect.FlatAppearance.BorderColor = Color.Red;
            btn_rect.FlatAppearance.BorderSize = 2;
            btn_rect.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 69, 0);
            btn_rect.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btn_rect.FlatStyle = FlatStyle.Flat;
            btn_rect.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_rect.ForeColor = SystemColors.ButtonHighlight;
            btn_rect.Image = Properties.Resources.rectangle;
            btn_rect.ImageAlign = ContentAlignment.TopCenter;
            btn_rect.Location = new Point(683, 29);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(85, 74);
            btn_rect.TabIndex = 6;
            btn_rect.Text = "Rect";
            btn_rect.TextAlign = ContentAlignment.BottomCenter;
            btn_rect.UseVisualStyleBackColor = false;
            btn_rect.Click += btn_rect_Click;
            // 
            // btn_ellipse
            // 
            btn_ellipse.BackColor = Color.Transparent;
            btn_ellipse.BackgroundImageLayout = ImageLayout.Zoom;
            btn_ellipse.Cursor = Cursors.Hand;
            btn_ellipse.FlatAppearance.BorderColor = Color.Red;
            btn_ellipse.FlatAppearance.BorderSize = 2;
            btn_ellipse.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 69, 0);
            btn_ellipse.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btn_ellipse.FlatStyle = FlatStyle.Flat;
            btn_ellipse.ForeColor = SystemColors.ButtonHighlight;
            btn_ellipse.Image = Properties.Resources.circle;
            btn_ellipse.ImageAlign = ContentAlignment.TopCenter;
            btn_ellipse.Location = new Point(572, 29);
            btn_ellipse.Name = "btn_ellipse";
            btn_ellipse.Size = new Size(85, 74);
            btn_ellipse.TabIndex = 5;
            btn_ellipse.Text = "Ellipse";
            btn_ellipse.TextAlign = ContentAlignment.BottomCenter;
            btn_ellipse.UseVisualStyleBackColor = false;
            btn_ellipse.Click += btn_ellipse_Click;
            // 
            // btn_color
            // 
            btn_color.BackColor = Color.Transparent;
            btn_color.BackgroundImageLayout = ImageLayout.Stretch;
            btn_color.Cursor = Cursors.Hand;
            btn_color.FlatAppearance.BorderColor = Color.Red;
            btn_color.FlatAppearance.BorderSize = 2;
            btn_color.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 69, 0);
            btn_color.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.ForeColor = SystemColors.ButtonHighlight;
            btn_color.Image = Properties.Resources.color2;
            btn_color.ImageAlign = ContentAlignment.TopCenter;
            btn_color.Location = new Point(16, 29);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(85, 74);
            btn_color.TabIndex = 1;
            btn_color.Text = "Color";
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = false;
            btn_color.Click += btn_color_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.BackColor = Color.Transparent;
            btn_pencil.BackgroundImageLayout = ImageLayout.Stretch;
            btn_pencil.Cursor = Cursors.Hand;
            btn_pencil.FlatAppearance.BorderColor = Color.Red;
            btn_pencil.FlatAppearance.BorderSize = 2;
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 69, 0);
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.ForeColor = SystemColors.ButtonHighlight;
            btn_pencil.Image = Properties.Resources.pencil;
            btn_pencil.ImageAlign = ContentAlignment.TopCenter;
            btn_pencil.Location = new Point(235, 29);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(85, 74);
            btn_pencil.TabIndex = 3;
            btn_pencil.Text = "Pencil";
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.UseVisualStyleBackColor = false;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.BackColor = Color.Transparent;
            btn_eraser.BackgroundImageLayout = ImageLayout.Stretch;
            btn_eraser.Cursor = Cursors.Hand;
            btn_eraser.FlatAppearance.BorderColor = Color.Red;
            btn_eraser.FlatAppearance.BorderSize = 2;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 69, 0);
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.ForeColor = SystemColors.ButtonHighlight;
            btn_eraser.Image = Properties.Resources.eraser;
            btn_eraser.ImageAlign = ContentAlignment.TopCenter;
            btn_eraser.Location = new Point(348, 29);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(85, 74);
            btn_eraser.TabIndex = 4;
            btn_eraser.Text = "Eraser";
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = false;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DimGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 891);
            panel2.Name = "panel2";
            panel2.Size = new Size(1641, 38);
            panel2.TabIndex = 1;
            // 
            // pic
            // 
            pic.BackColor = SystemColors.ButtonHighlight;
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(1641, 929);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Paint += pic_Paint;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Closer4
            // 
            Closer4.BackColor = Color.Transparent;
            Closer4.BackgroundImage = Properties.Resources._111;
            Closer4.BackgroundImageLayout = ImageLayout.Stretch;
            Closer4.FlatAppearance.BorderSize = 0;
            Closer4.FlatStyle = FlatStyle.Flat;
            Closer4.Font = new Font("Mongolian Baiti", 24F);
            Closer4.ImageAlign = ContentAlignment.TopCenter;
            Closer4.Location = new Point(1558, 37);
            Closer4.Name = "Closer4";
            Closer4.Size = new Size(59, 57);
            Closer4.TabIndex = 11;
            Closer4.UseVisualStyleBackColor = false;
            Closer4.Click += Closer4_Click;
            // 
            // Minimize4
            // 
            Minimize4.BackColor = Color.Transparent;
            Minimize4.BackgroundImage = Properties.Resources.line;
            Minimize4.BackgroundImageLayout = ImageLayout.Stretch;
            Minimize4.FlatAppearance.BorderSize = 0;
            Minimize4.FlatStyle = FlatStyle.Flat;
            Minimize4.Font = new Font("Mongolian Baiti", 24F);
            Minimize4.ImageAlign = ContentAlignment.TopCenter;
            Minimize4.Location = new Point(1562, 110);
            Minimize4.Name = "Minimize4";
            Minimize4.Size = new Size(55, 57);
            Minimize4.TabIndex = 12;
            Minimize4.UseVisualStyleBackColor = false;
            Minimize4.Click += Minimize4_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1641, 929);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pic);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            MouseClick += Form4_MouseClick;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button pic_color;
        private PictureBox pic;
        private Button btn_color;
        private Button btn_ellipse;
        private Button btn_eraser;
        private Button btn_pencil;
        private Button btn_fill;
        private Button btn_rect;
        private Button btn_line;
        private Panel panel3;
        private PictureBox color_picker;
        private Button btn_clear;
        private Button btn_save;
        private Button Closer4;
        private Button Minimize4;
    }
}