using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file224
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

            if (System.IO.Directory.Exists(fname) == true)  //フォルダー
            {
                System.IO.Directory.Delete(fname, true);
                label1.Text = $"{fname}を削除しました。";
            }
            else if (System.IO.File.Exists(fname) == true)  //ファイル
            {
                System.IO.File.Delete(fname);
                label1.Text = $"{fname}を削除しました。";
            }
            else
            {
                label1.Text = $"{fname}が見つかりませんでした。";
            }
        }
    }
}
