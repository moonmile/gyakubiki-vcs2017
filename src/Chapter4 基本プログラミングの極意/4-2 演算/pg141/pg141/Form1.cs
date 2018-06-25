using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg141
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rnd = new Random();

            //乱数を取得してラベルに表示する
            label1.Text = rnd.Next(100).ToString();
            label2.Text = rnd.Next(100, 1001).ToString();
        }
    }
}
