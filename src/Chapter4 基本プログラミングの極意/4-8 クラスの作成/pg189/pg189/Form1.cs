using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg189
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tel = new SampleClassTel("山田はなこ", "090-XXXX-XXXX");
            tel.ShowData();       //派生クラスのメソッド
        }
    }

    //派生クラス
    public class SampleClassTel : SampleClass
    {
        private string _tel;

        //コンストラクター
        public SampleClassTel(string name, string tel)
            : base(name)
        {
            _tel = tel;
        }

        //オーバーライドしたメソッド
        public override void ShowData()
        {
            base.ShowData();        //基本クラスのメソッドを呼び出す
            MessageBox.Show("お客様電話番号：" + _tel, "確認");
        }
    }

    //基本クラス
    public class SampleClass
    {
        private string _name;
        private string _id;

        //コンストラクター
        public SampleClass(string cName)
        {
            _name = cName;
            _id = DateTime.Now.ToString("yyMMddHHmm");
        }

        //オーバーライド可能なメソッド
        public virtual void ShowData()
        {
            MessageBox.Show($"お客様氏名： {_id}-{_name}", "確認");
        }
    }
}
