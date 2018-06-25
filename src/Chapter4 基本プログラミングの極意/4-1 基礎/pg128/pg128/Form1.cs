using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg128
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intX = 30;
            long longX = intX;                  //暗黙の型変換

            double doubleX = 123.456;
            intX = (int)doubleX;                //キャスト（桁落ちする）
            label1.Text = intX.ToString();      //ラベルに表示

            object objectX = intX;              //暗黙の型変換
            objectX = "Visual C# 2017";
            string stringX = (string)objectX;   //強制的にキャスト
            string stringY = objectX as string; //キャスト
        }
    }
}
