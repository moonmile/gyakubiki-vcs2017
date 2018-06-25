using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string210
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            label1.Text = "";
            if (text.Length < 7)
            {
                MessageBox.Show("7文字以上入力してください。", "通知");
                return;
            }
            label1.Text = text.Substring(4, 3);   //3文字取得
        }
    }
}
