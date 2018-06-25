using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file228
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dname = System.IO.Directory.GetCurrentDirectory();
            MessageBox.Show($"カレントフォルダーは {dname} です。", "通知");

            System.IO.Directory.SetCurrentDirectory("C:\\");
            MessageBox.Show("カレントフォルダーをC:\\に変更しました。\n"
                + "［OK］ボタンをクリックすると元に戻します。", "通知");
            System.IO.Directory.SetCurrentDirectory(dname);
        }
    }
}
