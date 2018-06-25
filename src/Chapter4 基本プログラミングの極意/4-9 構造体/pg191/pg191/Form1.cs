using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg191
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyMenu mn;
            //構造体の値を設定し、構造体メンバーのプロパティを使う
            mn.menuNo = 1;
            mn.Menu = "仙台味噌ラーメン";
            mn.price = 750;
            MessageBox.Show($"◎ 大盛り価格　---　\\ {mn.priceBig}", mn.Menu);
        }
    }
    public struct MyMenu       //構造体を定義
    {
        public int menuNo;
        public string Menu;
        public int price;
        public int priceBig     //プロパティをメンバーとする
        {
            get { return price + 100; }
        }
    }
}
