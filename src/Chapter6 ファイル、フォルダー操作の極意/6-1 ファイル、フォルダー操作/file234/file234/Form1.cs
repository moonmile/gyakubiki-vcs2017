using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file234
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text;

            if (System.IO.File.Exists(fname) == false)
            {
                return;
            }
            //読み取り専用にする
            System.IO.File.SetAttributes(
                    fname, System.IO.FileAttributes.ReadOnly);
            label1.Text = fname + " を読み取り専用にしました。";
        }
    }
}
