using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error322
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
                // 存在しないファイルを指定する
                var img = Image.FromFile(@"C:￥XYZXYZXYZ.jpg");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "エラー発生");
            }
        }
    }
}
