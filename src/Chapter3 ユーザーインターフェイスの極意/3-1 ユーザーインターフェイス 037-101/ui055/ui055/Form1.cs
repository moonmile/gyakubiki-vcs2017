using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui055
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = "別のフォームを開きます";
            //リンク文字列を設定
            linkLabel1.LinkArea = new LinkArea(2, 4);
        }

        private void linkLabel1_LinkClicked(object sender, 
            LinkLabelLinkClickedEventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();
            linkLabel1.LinkVisited = true;
        }
    }
}
