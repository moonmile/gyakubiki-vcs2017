using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file227
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text;
            //フォルダーまたはファイルの作成日時を取得して表示する
            if (System.IO.Directory.Exists(fname) == true)
            {
                label1.Text
                    = System.IO.Directory.GetCreationTime(fname).ToString();
            }
            else if (System.IO.File.Exists(fname) == true)
            {
                label1.Text
                    = System.IO.File.GetCreationTime(fname).ToString();
            }
            else
            {
                label1.Text = $"{fname}が見つかりませんでした。";
            }
        }
    }
}
