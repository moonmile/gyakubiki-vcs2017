using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string222
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = 10.12345;
            DateTime myDate = DateTime.Now;

            label1.Text = myDate.ToString("yy/MM/dd(ddd) HH:mm:ss");
            label2.Text = myDate.ToString("tt h:m:s");
            label3.Text = myDate.ToString("D");
            label4.Text = num.ToString("#.#");
            label5.Text = num.ToString("000.000");
            label6.Text = num.ToString("0.00%");
            label7.Text = num.ToString("C");
            label8.Text = num.ToString("P");
        }
    }
}
