using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app474
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // テキストをコピー
        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(textBox1.Text);
            MessageBox.Show("クリップボードにコピーしました。", "確認");
        }

        // 画像をコピー
        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetImage(pictureBox1.Image);
            MessageBox.Show("クリップボードにコピーしました。", "確認");
        }
    }
}
