using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui066
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (RadioButton myradioButton in panel1.Controls)
            {
                if (myradioButton.Checked)
                {
                    label2.Text = myradioButton.Text + " が選択されました";
                    break;
                }
            }
        }
    }
}
