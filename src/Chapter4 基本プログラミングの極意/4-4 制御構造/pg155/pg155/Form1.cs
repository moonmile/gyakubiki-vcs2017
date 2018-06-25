using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg155
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 11;

            listBox1.Items.Clear();
            do
            {
                listBox1.Items.Add($"No.{i}");
                i++;
            } while (i <= 10);          //iが10以下の間繰り返す
        }
    }
}
