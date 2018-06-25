using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg138
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control myObj in Controls)
            {
                if (myObj is Button)            //Buttonと等しい場合
                {
                    myObj.Text = "Clicked!";      //プロパティの値を変更
                }
            }
        }
    }
}
