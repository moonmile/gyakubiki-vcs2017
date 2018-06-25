using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui071
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("ホワイト");
            listBox1.Items.Add("イエロー");
            listBox1.Items.Add("ブルー");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] myArray = { "ホワイト", "イエロー", "ブルー" };
            listBox1.Items.Clear();
            listBox1.Items.AddRange(myArray);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.RemoveAt(0);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            }
        }
    }
}
