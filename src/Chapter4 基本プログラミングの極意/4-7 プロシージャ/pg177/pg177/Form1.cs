using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg177
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ret = retProc(10, 20);
            label1.Text = "取得した戻り値 ： " + ret.ToString();
        }

        //戻り値を返すメソッド
        private int retProc(int x, int y)
        {
            return x * y;    //引数をかけ合わせた数値を呼び出し元に戻す
        }
    }
}
