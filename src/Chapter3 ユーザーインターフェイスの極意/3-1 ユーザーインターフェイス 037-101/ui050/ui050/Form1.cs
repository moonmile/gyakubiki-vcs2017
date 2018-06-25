using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui050
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();

            //ダイアログボックスでクリックされたボタンによって
            //ラベルに表示する文字列を設定する
            switch (newForm.DialogResult)
            {
                case DialogResult.Yes:
                    label1.Text = "「はい」がクリックされました";
                    break;
                case DialogResult.No:
                    label1.Text = "「いいえ」がクリックされました";
                    break;
                case DialogResult.Cancel:
                    label1.Text = "「キャンセル」がクリックされました";
                    break;
            }
        }


    }
}
