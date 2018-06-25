using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg158
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = DateTime.Today;
            var RetStr = dt.Day <= 15 ? "前半" : "後半";
            label1.Text = $"今日の日付:{dt.ToShortDateString()}\n月の{RetStr}です。";
        }
    }
}
