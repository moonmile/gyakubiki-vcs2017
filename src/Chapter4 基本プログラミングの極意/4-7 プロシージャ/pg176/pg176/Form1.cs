using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg176
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xStr = "Param";
            string yStr = "Param";

            xProc(xStr);            //値渡しで渡す
            yProc(out yStr);        //参照渡しで渡す
            label1.Text = "値渡しの結果：" + xStr;
            label2.Text = "参照渡しの結果：" + yStr;
        }

        private void xProc(string xParam)     //値渡しの引数を受け取る
        {
            xParam = "Change!";
        }

        private void yProc(out string yParam) //参照渡しの引数を受け取る
        {
            yParam = "Change!";
        }

    }
}
