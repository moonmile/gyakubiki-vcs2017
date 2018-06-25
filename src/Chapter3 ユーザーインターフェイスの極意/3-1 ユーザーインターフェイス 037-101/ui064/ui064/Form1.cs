using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui064
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int a1, a2, a3, a4;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //チェックが付いていれば変数a1に35000を代入し、
            //チェックが付いていなければ、変数a1に0を代入する
            if (checkBox1.Checked)
            {
                a1 = 35000;
            }
            else
            {
                a1 = 0;
            }
            label2.Text = (a1 + a2 + a3 + a4).ToString("#,##0円");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //チェックが付いていれば変数a2に40000を代入し、
            //チェックが付いていなければ、変数a2に0を代入する
            if (checkBox2.Checked)
            {
                a2 = 40000;
            }
            else
            {
                a2 = 0;
            }
            label2.Text = (a1 + a2 + a3 + a4).ToString("#,##0円");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //チェックが付いていれば変数a3に20000を代入し、
            //チェックが付いていなければ、変数a3に0を代入する
            if (checkBox3.Checked)
            {
                a3 = 20000;
            }
            else
            {
                a3 = 0;
            }
            label2.Text = (a1 + a2 + a3 + a4).ToString("#,##0円");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //チェックが付いていれば変数a4に15000を代入し、
            //チェックが付いていなければ、変数a4に0を代入する
            if (checkBox4.Checked)
            {
                a4 = 15000;
            }
            else
            {
                a4 = 0;
            }
            label2.Text = (a1 + a2 + a3 + a4).ToString("#,##0円");
        }



    }
}
