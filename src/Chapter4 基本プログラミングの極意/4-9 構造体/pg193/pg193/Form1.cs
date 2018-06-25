using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg193
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            structBurgerSet bs;
            string[] setSize = { "S", "M", "L" };

            //構造体メンバーの値を設定してから表示する。
            bs.Burger = "ベーコンレタスバーガー";
            bs.Drink.Name = "オレンジジュース";
            bs.Drink.Size = setSize;          //配列を代入
            MessageBox.Show(
                $"バーガー名： {bs.Burger}\n" +
                $"ドリンク名： {bs.Drink.Name}\n" +
                $"ドリンクサイズ： {bs.Drink.Size[1]}", "確認");
        }
    }
    public struct structBurgerSet   //構造体の定義
    {
        public structDrink Drink; //構造体をメンバーとする
        public string Burger;
    }
    public struct structDrink       //構造体の定義
    {
        public string Name;
        public string[] Size;       //配列をメンバーとする
    }
}
