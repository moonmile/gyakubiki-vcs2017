using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui045
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         private void button1_Click(object sender, EventArgs e)
        {
            Width += 10;   //フォームの幅を現在の値に10ピクセル増やす
            Height += 10;  //フォームの高さを現在の値に10ピクセル増やす
        }
    }
}
