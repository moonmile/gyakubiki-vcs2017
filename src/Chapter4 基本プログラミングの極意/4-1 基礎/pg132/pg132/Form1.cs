using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg132
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dynamic x;

            //string型の引数を渡す。
            x = sampleMethod("Sample");
            label1.Text = x.ToString();
            //int型の引数を渡す。
            x = sampleMethod(15);
            label2.Text = x;
        }

        private dynamic sampleMethod(dynamic x)
        {
            if (x is string)
            {
                return 365;         //int型の戻り値
            }
            else
            {
                return "return";    //string型の戻り値
            }
        }
    }
}
