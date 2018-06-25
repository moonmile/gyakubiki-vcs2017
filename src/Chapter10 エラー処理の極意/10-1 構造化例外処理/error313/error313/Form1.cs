using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error313
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // メソッドを実行
                SampleProc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー発生");
            }
        }
        void SampleProc()
        {
            int a;
            // フォーマット変換エラーにする
            a = int.Parse("間違った値");
            // 例外はcatchしない
            MessageBox.Show($"a = {a}", "通知");
        }
    }
}
