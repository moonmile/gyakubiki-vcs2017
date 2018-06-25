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

namespace graph366
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var g = pictureBox1.CreateGraphics();
            // 画像を回転する
            var img = Properties.Resources.book;
            var mx = new Matrix();
            // 画像の中央で時計回りに45度回転させる
            mx.RotateAt(45, new Point(img.Width / 2, img.Height));
            g.Transform = mx;
            g.DrawImage(img, new Point(0, 0));
        }
    }
}
