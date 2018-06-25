using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg167
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lst = new System.Collections.ArrayList();

            lst.AddRange(listBox1.Items); //要素を追加
            label1.Text = $"最初の要素： {lst[0]}";
            label2.Text = $"要素数： {lst.Count}";
        }
    }
}
