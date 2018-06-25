using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialog247
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ダイアログボックスの初期設定を行う
            openFileDialog1.Title = "画像ファイルの選択";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "イメージファイル|*.bmp;*.jpg;*.gif";

            //ダイアログボックスを表示し、［開く］ボタンが選択されたら
            //ファイル名を表示し、ピクチャボックスに表示する
            var ret = openFileDialog1.ShowDialog();
            if (ret == DialogResult.OK)
            {
                label1.Text = openFileDialog1.FileName;
                label2.Text = openFileDialog1.SafeFileName;
                pictureBox1.Image
                        = Image.FromFile(openFileDialog1.FileName);
            }
            else
            {
                label1.Text = "";
                label2.Text = "";
                pictureBox1.Image = null;
            }
        }
    }
}
