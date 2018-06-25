using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui067
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton4.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myString1 = "", myString2 = "";

            foreach (RadioButton myradioButton1 in groupBox1.Controls)
            {
                if (myradioButton1.Checked)
                {
                    myString1 = "サイズ：" + myradioButton1.Text;
                    break;
                }
            }
            foreach (RadioButton myradioBotton2 in groupBox2.Controls)
            {
                if (myradioBotton2.Checked)
                {
                    myString2 = "色　　：" + myradioBotton2.Text;
                    break;
                }
            }
            label2.Text = myString1 + Environment.NewLine + myString2;

        }
    }
}
