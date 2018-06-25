using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui073
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                label1.Text = "選択されていません";
            }
            else
            {
                label1.Text = listBox1.SelectedIndex + 1 +
                            "番目：　" + listBox1.SelectedItem;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            label1.Text = "";
        }
    }
}
