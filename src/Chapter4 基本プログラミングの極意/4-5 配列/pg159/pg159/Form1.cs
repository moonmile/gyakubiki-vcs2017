using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg159
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ary = new int[5];

            label1.Text = "";
            for (int i = 0; i < 5; i++)
            {
                ary[i] = i * 2;
                label1.Text += $"ary[{i}] = {ary[i]}\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ary = new string[2, 3];

            label1.Text = "";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ary[i, j] = (i + j).ToString();
                    label1.Text += $"ary[{i}, {j}] = {ary[i, j]}　";
                }
                label1.Text += "\n";
            }
        }
    }
}
