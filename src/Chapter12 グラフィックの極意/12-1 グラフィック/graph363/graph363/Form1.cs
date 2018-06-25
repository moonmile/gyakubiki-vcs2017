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

namespace graph363
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
            // 透明色を指定する
            var ia = new ImageAttributes();
            ia.SetColorKey(Color.White, Color.White);
            // 画像を描画する
            var img = Properties.Resources.book;
            var rect = new Rectangle(0, 0, img.Width, img.Height);
            g.DrawImage(img, rect, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
        }
    }
}
