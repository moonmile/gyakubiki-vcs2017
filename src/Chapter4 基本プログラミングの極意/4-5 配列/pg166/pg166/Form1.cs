using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg166
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ary1 = { 10, 20, 30 };
            int[] ary2 = { 6, 7, 8, 9, 0 };
            int[] ary3 = (int[])ary1.Clone(); //Cloneメソッドでコピー
            int[] ary4 = ary1;                //配列を代入

            ary1.CopyTo(ary2, 2);             //CopyToメソッドでコピー
            ary1[0] = 99;                     //コピー後に値を変更

            //各配列の要素の値を表示する
            label1.Text = "ary1 = ";
            label2.Text = "ary2 = ";
            label3.Text = "ary3 = ";
            label4.Text = "ary4 = ";
            for (int i = 0; i < ary1.Length; i++)
            {
                label1.Text += $"{ary1[i]}  ";
            }
            for (int i = 0; i < ary2.Length; i++)
            {
                label2.Text += $"{ary2[i]}  "; ;
            }
            for (int i = 0; i < ary3.Length; i++)
            {
                label3.Text += $"{ary3[i]}  "; ;
            }
            for (int i = 0; i < ary4.Length; i++)
            {
                label4.Text += $"{ary4[i]}  "; ;
            }
        }
    }
}
