using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg162
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ary = new string[] { "東京", "名古屋", "大阪" };

            //配列aryの要素数と要素の値を表示する
            label1.Text = $"配列aryの要素数： {ary.Length}\n";
            label1.Text += $"ary[0]={ary[0]}, ary[1]={ary[1]}, ary[2]={ary[2]}";
            //要素数を変更後、要素数と値を表示する
            ary = new string[5];
            label2.Text = $"配列aryの要素数： {ary.Length}\n";
            label2.Text += $"ary[0]={ary[0]}, ary[1]={ary[1]}, ary[2]={ary[2]}";
        }
    }
}
