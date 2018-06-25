using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file226
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname1 = textBox1.Text;
            string fname2 = textBox2.Text;
            //コピー元ファイル無し、または、コピー先ファイル有り
            //または、コピー先フォルダー無しなら終了
            if (File.Exists(fname1) == false)
            {
                label1.Text = "コピー元のファイルがありません。";
                return;
            }
            if (File.Exists(fname2) == true)
            {
                label1.Text = "コピー先のファイルがあります。";
                return;
            }
            if (Directory.Exists(Path.GetDirectoryName(fname2)) == false)
            {
                label1.Text = "コピー先はディレクトリです。";
                return;
            }
            System.IO.File.Copy(fname1, fname2);    //コピー
            label1.Text = fname2 + "にコピーしました。";
        }
    }
}
