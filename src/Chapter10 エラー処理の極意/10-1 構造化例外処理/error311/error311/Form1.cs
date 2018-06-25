using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error311
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ary = { 1, 2, 3 }; //要素数が3の配列
            try
            {
                int num = ary[5]; //無効なインデックスを指定
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }
        }
    }
}
