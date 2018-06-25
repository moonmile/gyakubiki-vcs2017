using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialog251
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "フォルダーを選択してください。";

            //［新しいフォルダを作成］ボタンを表示しない
            folderBrowserDialog1.ShowNewFolderButton = false;

            //ダイアログボックスを表示し、［OK］ボタンが選択されたらフォルダーパスを表示
            var ret = folderBrowserDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                label1.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                label1.Text = "";
            }
        }
    }
}
