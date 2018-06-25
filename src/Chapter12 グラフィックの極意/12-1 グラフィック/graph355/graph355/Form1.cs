using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph355
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var g = this.pictureBox1.CreateGraphics();
            // 普通の直線
            g.DrawLine(Pens.Black, 0, 0, this.pictureBox1.Width, 0);
            // 太い線
            var boldPen = new Pen(Color.Black, 5);
            g.DrawLine(boldPen, 0, 30, this.pictureBox1.Width, 30);
            // 点線
            var dotPen = new Pen(Color.Black);
            dotPen.DashStyle = DashStyle.Dot;
            g.DrawLine(dotPen, 0, 60, this.pictureBox1.Width, 60);
        }
    }
}
