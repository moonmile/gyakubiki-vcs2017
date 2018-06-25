using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg127
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ClassType列挙型を定義する
        enum ClassType     //データ型を省略しているのでint型となる
        {
            Special,       //0
            Standard,      //1
            Basic,         //2
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassType result;           //ClassType型で宣言

            switch (comboBox1.SelectedIndex)
            {
                case (int)ClassType.Special:
                    result = ClassType.Special;
                    break;
                case (int)ClassType.Standard:
                    result = ClassType.Standard;
                    break;
                default:
                    result = ClassType.Basic;
                    break;
            }
            label1.Text = result.ToString();
        }
    }
}
