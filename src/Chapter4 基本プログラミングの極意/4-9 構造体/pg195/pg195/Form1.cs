using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg195
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //構造体を戻り値として返すメソッド
        private StructPoint twicePoint(int x, int y)
        {
            StructPoint aPoint;

            aPoint.X = x * 2;
            aPoint.Y = y * 2;
            return aPoint;              //構造体を返す
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StructPoint pt;

            //メソッドを呼び出して、構造体を戻り値として受け取る
            pt = twicePoint(100, 200);
            MessageBox.Show($"xの位置　：　{pt.X}\n" +
                            $"yの位置　：　{pt.Y}", "戻り値の構造体の値");
        }

    }
    public struct StructPoint      //構造体を定義
    {
        public int X;
        public int Y;
    }
}
