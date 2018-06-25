using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file238
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            if (System.IO.File.Exists(path) == false)
            {
                MessageBox.Show("ファイルが見つかりません。", "通知");
                return;
            }
            var rs = System.IO.File.OpenRead(path);
            MessageBox.Show("ファイルを開きました。", "通知");
            rs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            if (path == "")
            {
                return;         //入力無しなら終了
            }
            var ws = new System.IO.StreamWriter(
                    path, true, System.Text.Encoding.Default);
            MessageBox.Show("ファイルを開きました。", "通知");
            ws.Close();
        }
    }
}
