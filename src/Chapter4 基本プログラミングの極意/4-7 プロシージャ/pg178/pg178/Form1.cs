using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg178
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] xAry = { "London", "Paris", "NewYork" };

            var yAry = aryProc(xAry);       //配列を渡して配列を受け取る
            label2.Text = "";
            foreach (string city in yAry)   //受け取った配列を表示
            {
                label2.Text += $"{city}\n";
            }
        }

        //配列を受け渡しするメソッド
        private string[] aryProc(string[] aParam)
        {
            label1.Text = "";
            foreach (string city in aParam) //受け取った配列を表示
            {
                label1.Text += $"{city}\n";
            }
            aParam[2] = "Tokyo";
            return aParam;              //配列を返す
        }
    }
}
