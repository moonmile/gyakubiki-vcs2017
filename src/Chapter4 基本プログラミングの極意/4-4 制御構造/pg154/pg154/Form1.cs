using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg154
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;

            listBox1.Items.Clear();
            while (i < 11)              //iが11未満の間繰り返す
            {
                listBox1.Items.Add($"No.{i}");
                i++;
            }
        }
    }
}
