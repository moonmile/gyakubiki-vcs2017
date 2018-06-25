using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialog248
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ダイアログボックスの初期設定
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.Filter = "JPeg（*.jpg）|*.jpg|Gif（*.gif）|*.gif";

            //ダイアログボックスを表示し、キャンセルなら終了
            var ret = saveFileDialog1.ShowDialog();
            if (ret == DialogResult.Cancel)
            {
                return;
            }

            //ファイル名を表示し、ピクチャーボックスのイメージを保存する
            label1.Text = System.IO.Path.GetFileName(
                                saveFileDialog1.FileName);
            var fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
            if (saveFileDialog1.FilterIndex == 1)
            {
                pictureBox1.Image.Save(
                        fs, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                pictureBox1.Image.Save(
                        fs, System.Drawing.Imaging.ImageFormat.Gif);
            }
            fs.Close();
            label2.Text = "保存しました。";
        }
    }
}
