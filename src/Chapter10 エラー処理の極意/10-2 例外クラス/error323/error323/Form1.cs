using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error323
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 存在しないフォルダを指定する
                foreach (var fname in System.IO.Directory.GetFiles(@"c:\azyx"))
                {
                    MessageBox.Show(fname, "通知");
                }
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "エラー発生");
            }
        }
    }
}
