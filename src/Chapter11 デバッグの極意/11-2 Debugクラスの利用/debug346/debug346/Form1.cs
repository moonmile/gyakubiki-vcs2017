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

namespace debug346
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
                // iが25を超えたら警告メッセージを表示する
                Debug.Assert(i <= 25, "{i} : 定員オーバーです。");
            }
        }
    }
}
