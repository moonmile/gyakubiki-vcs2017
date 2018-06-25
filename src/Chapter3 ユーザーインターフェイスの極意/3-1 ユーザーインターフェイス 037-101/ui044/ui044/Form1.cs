using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui044
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
            //フォームを画面左上に表示する
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = new Point(0, 0); //左上の位置を指定する 
            newForm.Show(); //フォームを表示する
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            //フォームを画面中央に表示する
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.Show(); //フォームを表示する
        }

    }
}
