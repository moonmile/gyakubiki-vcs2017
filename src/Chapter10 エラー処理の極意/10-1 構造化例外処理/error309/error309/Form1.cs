using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error309
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                // 正常値を代入
                a = 10;
                // 関数を抜ける
                return;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "エラー発生");
            }
            finally
            {
                MessageBox.Show("Finallyブロックの処理", "通知");
            }
        }
    }
}
