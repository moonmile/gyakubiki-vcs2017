using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg185
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
    //Class1クラス
    class Class1
    {
        //イベントを定義する
        public event Action<object, EventArgs> MyEvent;
        public event EventHandler ev;


        public void MyMethod()
        {
            string msg = DateTime.Now.ToString("HH:mm:ss");
            //イベントを発生させる
            if (MyEvent != null)
                MyEvent(this, EventArgs.Empty);
        }
    }
}
