using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debug345
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 30; i++)
            {
                if (i > 25)
                {
                    // 警告メッセージと詳細メッセージを表示する
                    Debug.Fail("定員オーバーです。",
                        "「簡単クッキングコース」の定員は25名です。");
                }
            }
        }
    }
}
