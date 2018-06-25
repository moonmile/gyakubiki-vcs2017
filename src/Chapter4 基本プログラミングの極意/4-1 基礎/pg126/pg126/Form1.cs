using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg126
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string APPLI = "Visual C#2017 逆引き大全";
        const int TIPS_NUM = 555;

        private void button1_Click(object sender, EventArgs e)
        {
            const string STR = "の極意";
            label1.Text = APPLI + " " + TIPS_NUM.ToString() + STR;
            label2.Text = $"{APPLI} {TIPS_NUM}{STR}";
        }
    }
}
