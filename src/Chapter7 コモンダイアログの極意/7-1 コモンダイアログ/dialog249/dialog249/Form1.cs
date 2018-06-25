using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialog249
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true; //色の選択を可能にする

            //リッチテキストボックスのフォントと色をダイアログに反映
            fontDialog1.Font = richTextBox1.SelectionFont;
            fontDialog1.Color = richTextBox1.SelectionColor;

            //ダイアログボックスを表示し、［OK］ボタンが選択されたらリッチテキストボックスに反映
            var ret = fontDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }
    }
}
