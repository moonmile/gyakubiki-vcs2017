using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg192
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var mc = new MyStruct[3];  //構造体配列の宣言

            listBox1.Items.Clear();    //リストボックスをクリア
            for (int i = 0; i < 3; i++)     //各要素に値を代入して表示
            {
                mc[i].CourseNo = (i + 1).ToString("00");
                mc[i].CourseName = "コース名未定";
                mc[i].Num = 20;
                var m = mc[i];
                listBox1.Items.Add($"{m.CourseNo}-{m.CourseName}-{m.Num}名");
            }
        }
    }
    public struct MyStruct      //構造体を定義
    {
        public string CourseNo;
        public string CourseName;
        public int Num;
    }
}
