using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg187
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //インスタンスの生成と同時にプロパティの値を設定する
            SampleClass sc = new SampleClass { Name = "山田はなこ" };
            label1.Text = sc.Name;     //プロパティの値を表示
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
                return _name;   //thisNameの値を返す
            }
            set
            {
                _name = value;  //thisNameの値を設定
            }
        }
    }
}
