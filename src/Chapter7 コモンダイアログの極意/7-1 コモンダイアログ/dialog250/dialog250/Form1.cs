using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialog250
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ダイアログボックスを表示し、［OK］ボタンが選択されたらラベルに反映
            var ret = colorDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                label1.BackColor = colorDialog1.Color;
            }
        }
    }
}
