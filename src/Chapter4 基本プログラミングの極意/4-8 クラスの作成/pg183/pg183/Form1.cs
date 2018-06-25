using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg183
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myClass = new SampleClass("新規お客様");

            //Nameプロパティに値を設定してから取得する
            myClass.Name = "山田はなこ";
            MessageBox.Show("Nameプロパティの値： " + myClass.Name, "確認");
        }
    }

    //SampleClassクラス
    public class SampleClass
    {
        private string _name;

        //thisNameの値を設定/取得するプロパティ
        public string Name
        {
            get
            {
                return _name;   //thisNameプロパティの値を返す
            }
            set
            {
                _name = value;  //thisNameプロパティの値を設定
            }
        }

        //クラスのコンストラクター
        public SampleClass(string cName)
        {
            _name = cName;
        }
    }
}
