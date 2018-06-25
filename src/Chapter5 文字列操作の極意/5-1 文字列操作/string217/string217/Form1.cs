using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string217
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;

            if (text1.Length < 4)
            {
                MessageBox.Show("4文字以上入力してください。", "通知");
                return;
            }
            label1.Text = text1.Remove(1, 3);
        }
    }
}
