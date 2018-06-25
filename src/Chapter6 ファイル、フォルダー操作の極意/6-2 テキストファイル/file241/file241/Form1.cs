using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file241
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            if (System.IO.File.Exists(path) == false)
            {
                MessageBox.Show("ファイルが見つかりません。", "通知");
                return;
            }
            var st = new System.IO.StreamReader(
                        path, System.Text.Encoding.Default);
            label1.Text = st.ReadToEnd();  //一度に読み取る
            st.Close();                    //ストリームを閉じる
        }
    }
}
