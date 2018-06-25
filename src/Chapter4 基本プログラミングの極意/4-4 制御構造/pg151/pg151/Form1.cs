using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg151
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt;
            //入力されているかどうか、日付に変換可能かチェックする
            if (textBox1.Text == "")
            {
                label1.Text = "入力されていません。";
            }
            else if (DateTime.TryParse(textBox1.Text, out dt))
            {
                label1.Text = "入力した日付：" + dt;
            }
            else
            {
                label1.Text = "正しい日付を入力してください。";
            }
        }
    }
}
