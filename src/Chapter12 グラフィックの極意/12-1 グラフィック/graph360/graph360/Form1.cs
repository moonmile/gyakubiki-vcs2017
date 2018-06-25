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

namespace graph360
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
            // グラデーションを作成
            var br = new LinearGradientBrush(
                new Point(0, 0), new Point(0, this.pictureBox1.Height),
                Color.Green, Color.White);
            // グラデーションで塗り潰し
            g.FillRectangle(br, 0, 0, this.pictureBox1.Width, this.pictureBox1.Height);
        }
    }
}
