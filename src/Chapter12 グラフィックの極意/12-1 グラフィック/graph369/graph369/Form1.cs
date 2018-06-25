using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph369
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
            // リソースから取得する
            var img = Properties.Resources.kaho;
            // 画像を描画する
            g.DrawImage(img, 0, 0);
        }
    }
}
