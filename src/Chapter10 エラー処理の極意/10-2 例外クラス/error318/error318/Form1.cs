using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error318
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            try
            {
                // 空文字を指定
                label1.Text = int.Parse(s).ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "エラー発生");
            }
        }
    }
}
