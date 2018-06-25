using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg182
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

            MessageBox.Show("SampleClassのインスタンスを生成しました。", "確認");
        }
    }
    //SampleClassクラス
    public class SampleClass
    {
        private string _name;
        private string _id;

        //クラスのコンストラクター
        public SampleClass(string name)
        {
            _name = name;
            _id = DateTime.Now.ToString("yyMMddHHmm");
        }
    }
}
