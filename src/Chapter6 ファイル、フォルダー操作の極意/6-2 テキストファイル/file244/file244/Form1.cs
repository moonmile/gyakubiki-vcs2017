using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file244
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ws = System.IO.File.AppendText(textBox1.Text);
            ws.WriteLine(textBox2.Text);
            ws.Close();
            label1.Text = "ファイルに追加しました。";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ws = new System.IO.StreamWriter(
                textBox1.Text, true,
                System.Text.Encoding.GetEncoding("shift_jis"));
            ws.WriteLine(textBox2.Text);
            ws.Close();
            label1.Text = "ファイルに追加しました。";
        }
    }
}
