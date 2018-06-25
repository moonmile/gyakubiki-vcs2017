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

namespace file233
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
            listBox1.Items.Clear();
            if (File.Exists(fname) == false) //ファイルが無ければ終了
            {
                return;
            }
            //それぞれの属性をチェックする
            var attr = File.GetAttributes(fname);
            if ((attr & FileAttributes.ReadOnly) != 0)
            {
                listBox1.Items.Add("読み取り専用");
            }
            if ((attr & System.IO.FileAttributes.Hidden) != 0)
            {
                listBox1.Items.Add("隠しファイル");
            }
            if ((attr & System.IO.FileAttributes.Compressed) != 0)
            {
                listBox1.Items.Add("圧縮ファイル");
            }
            if ((attr & System.IO.FileAttributes.System) != 0)
            {
                listBox1.Items.Add("システムファイル");
            }

        }
    }
}
