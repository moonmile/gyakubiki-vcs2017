using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error320
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = "abc";
            string text2 = null;
            try
            {
                // null を渡す
                label1.Text = text1.Insert(2, text2);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "エラー発生");
            }
        }
    }
}
