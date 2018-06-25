using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph367
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 表示するページ番号
        private int page = -1;
        // ページを切り替える
        private void button1_Click(object sender, EventArgs e)
        {
            var g = pictureBox1.CreateGraphics();
            var img = Properties.Resources.Panorama;
            // ページを進める
            if (++page >= 5)
            {
                page = 0;
            }
            // 部分を表示する
            var pt = new Point(0, page * 208);
            g.DrawImage(img, new Rectangle(0, 0, 277, 208),
                new Rectangle(0, page * 208, 277, 208), GraphicsUnit.Pixel);
        }
    }
}
