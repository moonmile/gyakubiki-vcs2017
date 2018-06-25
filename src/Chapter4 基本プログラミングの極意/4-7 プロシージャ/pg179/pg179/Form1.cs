using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg179
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            xProc(true);                   //2つ目の引数を省略
            xProc(false, "数学");          //2つ目の引数に値を1つ渡す
            xProc(false, "国語", "社会");  //2つ目の引数に値を複数渡す
        }

        //省略可能な引数を受け取るメソッド
        private void xProc(bool result, params string[] kamoku)
        {
            string gouhi = "合格";

            if (result == false)
            {
                gouhi = "追試 -->";
            }
            foreach (string item in kamoku)
            {
                gouhi += " " + item;
            }
            MessageBox.Show("期末試験の結果 　： 　" + gouhi, "確認");
        }
    }
}
