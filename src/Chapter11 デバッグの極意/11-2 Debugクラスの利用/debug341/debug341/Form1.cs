using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace debug341
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("インデント前");
            Debug.Indent();
            Debug.WriteLine("インデント1回目");
            Debug.Indent();
            Debug.WriteLine("インデント2回目");
            Debug.Unindent();
            Debug.WriteLine("インデントを1回戻した後");
            Debug.Unindent();
            Debug.WriteLine("インデントを2回戻した後");
        }
    }
}
