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

namespace graph361
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
            // 透明度を指定する
            var cm = new ColorMatrix();
            cm.Matrix00 = 1f;
            cm.Matrix11 = 1f;
            cm.Matrix22 = 1f;
            cm.Matrix33 = 0.5f;
            cm.Matrix44 = 1f;
            var ia = new ImageAttributes();
            ia.SetColorMatrix(cm);
            // 画像を描画する
            var img = Properties.Resources.book;
            var rect = new Rectangle(0, 0, img.Width, img.Height);
            g.DrawImage(img, rect, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
        }
    }
}
