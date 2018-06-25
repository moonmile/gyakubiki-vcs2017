using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui043
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog(); //フォームをモーダルで表示
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show(); //フォームをモードレスで表示
        }
    }
}
