using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file245
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var st = new System.IO.StreamWriter(textBox1.Text);
            st.WriteLine(DateTime.Now.ToString());  //日付
            st.Write(textBox2.Text);                //出力データ
            st.WriteLine();                         //行終端文字
            st.Close();
            label1.Text = "ファイルに出力しました。";
        }
    }
}
