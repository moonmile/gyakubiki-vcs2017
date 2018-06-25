using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file246
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ws = new System.IO.StreamWriter(new System.IO.FileStream(
                            textBox1.Text, System.IO.FileMode.Create));
            ws.Write(textBox2.Text);
            ws.Close();
            label1.Text = "ファイルに出力しました。";
        }
    }
}
