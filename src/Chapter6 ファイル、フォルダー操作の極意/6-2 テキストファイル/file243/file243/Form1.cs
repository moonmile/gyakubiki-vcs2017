using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file243
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
            var rs = System.IO.File.CreateText(path);
            rs.Close();
            label1.Text = "ファイルを作成しました。";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            var rs = new System.IO.StreamWriter(
                    path, false, System.Text.Encoding.GetEncoding("shift_jis"));
            rs.Close();
            label1.Text = "ファイルを作成しました。";
        }
    }
}
