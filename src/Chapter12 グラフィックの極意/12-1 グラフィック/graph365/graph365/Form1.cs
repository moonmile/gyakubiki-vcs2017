using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph365
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 画像に合わせてフォームを変形
            pictureBox1.Image = Properties.Resources.book;
            BackColor = Color.Red;
            // 透明色を設定する
            TransparencyKey = Color.Red;
            // フレームを消す
            FormBorderStyle = FormBorderStyle.None;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 元に戻す
            TransparencyKey = Color.Empty;
            BackColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
