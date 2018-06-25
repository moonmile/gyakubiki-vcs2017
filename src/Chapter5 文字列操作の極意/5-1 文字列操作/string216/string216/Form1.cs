using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string216
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;

            if (text1 == String.Empty)
            {
                return;         //入力無しなら終了
            }
            label1.Text = "「" + text1.Trim() + "」";
            label2.Text = "「" + text1.TrimStart() + "」";
            label3.Text = "「" + text1.TrimEnd() + "」";
        }
    }
}
