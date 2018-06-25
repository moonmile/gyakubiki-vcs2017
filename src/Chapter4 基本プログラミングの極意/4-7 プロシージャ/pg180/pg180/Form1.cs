using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg180
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sampleProc("1月");
            sampleProc(2);
        }

        //string型の引数を受け取るsampleProcメソッド
        private void sampleProc(string nextMonth)
        {
            MessageBox.Show($"次回の放送は {nextMonth} です。", "通知");
        }

        //int型の引数を受け取るsampleProcメソッド
        private void sampleProc(int nextMonth)
        {
            sampleProc($"{nextMonth}月");   //もう一方のSampleProcを呼び出す
        }
    }
}
