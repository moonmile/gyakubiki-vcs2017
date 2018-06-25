using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error307
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            try
            {
                a = int.Parse("間違った値");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "エラー発生");
            }
        }
    }
}
