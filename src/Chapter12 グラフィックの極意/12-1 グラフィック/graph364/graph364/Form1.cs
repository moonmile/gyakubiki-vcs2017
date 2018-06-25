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

namespace graph364
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // パスを作成する
            var path = new GraphicsPath();
            path.StartFigure();
            path.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
            path.CloseFigure();
            // 領域を設定する
            Region = new Region(path);
        }
    }
}
