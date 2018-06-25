using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui120
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

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 左右に整列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);  //左右に並べて表示
        }

        private void 上下に整列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);  //上下に並べて表示
        }

        private void 重ねて整列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);        //重ねて表示
        }

        private void 閉じるToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myForm = this.ActiveMdiChild;  //子フォームを変数myFormに代入
            if (myForm == null)
            {
                return;
            }
            else
            {
                myForm.Close();  //子フォームを閉じる
            }
        }
    }
}
