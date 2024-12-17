using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Drawingapp.Resources;

namespace Drawingapp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Closer3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
