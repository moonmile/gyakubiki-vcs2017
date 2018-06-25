using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg184
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sc = new SampleClass("新規お客様");

            sc.ShowData();
            MessageBox.Show("氏名：" + sc.GetName("山田はなこ様"), "確認");
        }
    }

    //SampleClassクラス
    public class SampleClass
    {
        private string _name;

        //ThisNameの値を表示するメソッド
        public void ShowData()
        {
            MessageBox.Show("お客様名：　" + _name, "確認");
        }

        //受け取った文字列の最後から「様]を除くメソッド
        public string GetName(string name)
        {
            if (name.EndsWith("様"))
            {
                return name.Substring(0, name.Length - 1);
            }
            else
            {
                return name;
            }
        }

        //クラスのコンストラクター
        public SampleClass(string name)
        {
            _name = name;
        }
    }
}
