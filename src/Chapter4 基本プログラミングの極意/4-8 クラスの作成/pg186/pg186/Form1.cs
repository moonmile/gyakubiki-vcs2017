using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg186
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Class1クラスのインスタンスを生成し、myClassに取得する
        Class1 myClass = new Class1();

        //button1のClickイベントのイベントハンドラー
        private void button1_Click(object sender, EventArgs e)
        {
            //イベントにイベントハンドラーを追加する
            myClass.MyEvent += MyClass_MyEvent;
            //Class1クラスのメソッドを実行する（イベントが発生）
            myClass.myMethod();
        }
        //Class1クラスのイベントmyEventのイベントハンドラー
        private void MyClass_MyEvent(string obj)
        {
            label1.Text = obj;
        }
    }
    //Class1クラス
    class Class1
    {
        //イベントを定義する
        public event Action<string> MyEvent;

        public void myMethod()
        {
            string msg = DateTime.Now.ToString("HH:mm:ss");
            //イベントを発生させる
            if (MyEvent != null)
                MyEvent(msg);
        }
    }
}
