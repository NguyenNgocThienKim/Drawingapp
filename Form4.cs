using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawingapp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            this.Width = 1663;
            this.Height = 929;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;

        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {

                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }

                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }

            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {

            paint = false;

            sX = x - cY;
            sY = y - cY;


            if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            if (pb.Image == null) return Point.Empty;

            // Original image size
            int imgWidth = pb.Image.Width;   // 506
            int imgHeight = pb.Image.Height; // 168

            // PictureBox size
            int boxWidth = pb.ClientSize.Width;
            int boxHeight = pb.ClientSize.Height;

            // Calculate scaling ratio
            float ratioX = (float)boxWidth / imgWidth;
            float ratioY = (float)boxHeight / imgHeight;
            float scale = Math.Min(ratioX, ratioY); // Maintain aspect ratio (Zoom mode)

            // Calculate letterbox margins
            int xOffset = (int)((boxWidth - (imgWidth * scale)) / 2);
            int yOffset = (int)((boxHeight - (imgHeight * scale)) / 2);

            // Adjust click point to exclude margins
            int adjustedX = pt.X - xOffset;
            int adjustedY = pt.Y - yOffset;

            // Check if the adjusted point is within the scaled image
            if (adjustedX < 0 || adjustedY < 0 || adjustedX > imgWidth * scale || adjustedY > imgHeight * scale)
                return Point.Empty;

            // Map to original image coordinates
            int imageX = (int)(adjustedX / scale);
            int imageY = (int)(adjustedY / scale);

            return new Point(imageX, imageY);
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            if (color_picker.Image == null)
            {
                MessageBox.Show("No image is loaded in the color picker.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Point point = set_point(color_picker, e.Location);

            if (point == Point.Empty)
            {
                MessageBox.Show("Clicked point is outside the image bounds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the color at the calculated image coordinates
            Bitmap bmp = (Bitmap)color_picker.Image;
            Color color = bmp.GetPixel(point.X, point.Y);

            // Update color display
            pic_color.BackColor = color;
            new_color = color;
            p.Color = color;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            color_picker.Image = Image.FromFile("D:\\Final maam cathy\\color_palette.png");
            LoadImage();
        }

        private void LoadImage()
        {
            color_picker.Image = Image.FromFile("D:\\Final maam cathy\\color_palette.png");
            color_picker.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                }
            }
        }

        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_color);
            }
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void Closer4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
