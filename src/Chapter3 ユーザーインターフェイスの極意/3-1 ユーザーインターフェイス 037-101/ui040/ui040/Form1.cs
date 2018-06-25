using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui040
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //ヘルプボタンをクリックした後、ボタンをクリックした時に
            //実行する処理：メッセージの表示
            MessageBox.Show("ボタンをクリックすると終了します");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ボタンをクリックしたときに実行する処理：終了する
            this.Close();
        }
    }
}
