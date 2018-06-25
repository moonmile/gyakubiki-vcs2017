using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui117
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 新規ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = new Form();   //子フォームの作成

            //リッチテキストボックスの作成と設定
            RichTextBox myRichTextBox = new RichTextBox();
            myRichTextBox.Dock = DockStyle.Fill;

            //子フォームの設定
            myForm.MdiParent = this;    //親フォームを指定
            myForm.Text = "文書" + MdiChildren.Length; //タイトルバーの設定
            myForm.Size = new Size(250, 250); //フォームのサイズを設定
            myForm.Controls.Add(myRichTextBox);  //リッチテキストボックスの追加
            myForm.Show();  //フォームを開く
        }
    }
}
