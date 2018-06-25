using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            try
            {
                System.Diagnostics.Process.Start(s);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }
        }
    }
}
