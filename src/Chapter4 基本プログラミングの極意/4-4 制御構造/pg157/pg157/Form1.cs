using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg157
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "";
            string str2 = "";

            foreach (RadioButton chk in groupBox1.Controls)
            {
                if (chk.Checked == true)
                {
                    str1 += chk.Text + "  ";
                    continue;           //処理をループの先頭に戻す
                }
                else
                {
                    str2 += chk.Text + "  ";
                }
            }

            if (str1 != "")
            {
                MessageBox.Show(
                    $"{str1}\nが選択されました。\n\n" +
                    $"{str2}\nが選択されませんでした。", "確認");
            }
        }
    }
}
