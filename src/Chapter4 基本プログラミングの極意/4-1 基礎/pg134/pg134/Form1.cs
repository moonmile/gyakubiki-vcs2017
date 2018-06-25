using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg134
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ret = MessageBox.Show("アプリケーションを終了しますか？"
                                    , "確認", MessageBoxButtons.YesNo);
            if (ret == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
