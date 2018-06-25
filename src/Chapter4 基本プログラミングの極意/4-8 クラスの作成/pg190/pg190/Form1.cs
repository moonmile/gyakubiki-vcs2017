using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg190
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string型を指定したジェネリッククラスのインスタンスを生成
            var genericStr
                    = new MyGeneric<string>() { Value = "Visual C#" };
            //int型を指定したジェネリッククラスのインスタンスを生成
            var genericInt
                    = new MyGeneric<int>() { Value = 2017 };
            //それぞれのValueプロパティの値を表示する
            MessageBox.Show( $"{genericStr.Value} {genericInt.Value}", "確認");
        }
    }

    //ジェネリッククラスの定義
    public class MyGeneric<T>
    {
        private T _val;      //型指定できるフィールドの宣言

        public T Value
        {
            get { return _val; }
            set { _val = value; }
        }
    }
}
