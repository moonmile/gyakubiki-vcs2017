using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string220
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
            var textArray = text1.Split('/');   //文字列を分割
            listBox1.Items.Clear();              //リストボックスをクリア
            foreach (string text2 in textArray)
            {
                listBox1.Items.Add(text2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            var textArray = text1.Split(new string[] { "/" }, 
                StringSplitOptions.None);        //文字列を分割
            listBox1.Items.Clear();              //リストボックスをクリア
            foreach (string text2 in textArray)
            {
                listBox1.Items.Add(text2);
            }
        }
    }
}
