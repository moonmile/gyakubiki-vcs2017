using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app477
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // クリップボードへ転送
            var text = textBox1.Text;
            Clipboard.Clear();
            Clipboard.SetData(DataFormats.Html, text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // クリップボードから取得
            if (Clipboard.ContainsData(DataFormats.Html))
            {
                var html = Clipboard.GetData(DataFormats.Html);
                textBox1.Text = html as string;
            }
        }
    }
}
