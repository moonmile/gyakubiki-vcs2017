using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error317
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 0;
            try
            {
                if (b == 0)
                {
                    throw new SampleException("0による除算はできません。");
                }
                a = a / b;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー");
            }
        }
    }
    public class SampleException : Exception
    {
        public SampleException()
            : base()
        {
        }

        public SampleException(string msg)
            : base(msg)
        {
        }

        public SampleException(string msg, Exception inner)
            : base(msg, inner)
        {
        }
    }
}
