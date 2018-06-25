using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg194
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //構造体を引数として受け取るメソッド
        private void showData(StructMenu nMenu)
        {
            MessageBox.Show(
                $"{nMenu.Menu} : {nMenu.Price}円", "確認");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StructMenu mn;

            //構造体の値を設定し、メソッドを呼び出す
            mn.MenuNo = 1;
            mn.Menu = "仙台味噌ラーメン";
            mn.Price = 750;
            showData(mn);       //構造体を受け取るメソッドを呼び出す
        }

    }
    public struct StructMenu      //構造体を定義
    {
        public int MenuNo;
        public string Menu;
        public int Price;
    }
}
