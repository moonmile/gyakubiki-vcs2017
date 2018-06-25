using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui047
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AcceptButton = button1;
            CancelButton = button2;
            label1.Text =
            "フォームの読み込み時にAcceptボタン、Cancelボタンを設定しました";
            button1.Text = "OK";
            button2.Text = "Cancel";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OKボタンがクリックされました", "結果");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelボタンがクリックされました", "結果");
        }
    }
}
