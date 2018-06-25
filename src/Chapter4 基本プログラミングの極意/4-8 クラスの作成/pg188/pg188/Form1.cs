using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg188
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

            MessageBox.Show("名前 　:  　" + tel.Name, "派生クラス");
        }
    }
    //派生クラスの定義
    public class SampleClassTel : SampleClass
    {
        private string _tel;

        //コンストラクター（基本クラスのコンストラクターを呼び出す）
        public SampleClassTel(string name, string tel)
            : base(name)
        {
            _tel = tel;
        }

        //Telの値を取得するプロパティ
        public string Tel
        {
            get { return _tel; }
        }
    }

    //基本クラスの定義
    public class SampleClass
    {
        private string _name;
        private string _id;

        //コンストラクター
        public SampleClass(string cName)
        {
            _name = cName;
            _id = DateTime.Now.ToString("yymmddhhmm");
        }

        //Nameの値を取得するプロパティ
        public string Name
        {
            get { return _name; }
        }
    }
}
