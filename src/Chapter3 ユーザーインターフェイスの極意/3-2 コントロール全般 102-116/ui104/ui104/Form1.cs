using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui104
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(360, 300);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Width = 120;
            pictureBox1.Height = 100;
        }
    }
}
