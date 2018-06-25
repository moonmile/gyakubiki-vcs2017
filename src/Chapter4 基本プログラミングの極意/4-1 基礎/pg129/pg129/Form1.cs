using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg129
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double answer;      //数値型で宣言

            //ラベルの文字列をdouble型に変換して計算する
            answer = double.Parse(label1.Text)
                    + double.Parse(label2.Text);

            //double型の数値を文字列に変換してラベルに表示する
            this.label3.Text = answer.ToString();
        }
    }
}
