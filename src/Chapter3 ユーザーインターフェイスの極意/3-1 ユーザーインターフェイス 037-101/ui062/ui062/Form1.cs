﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
            {
                label3.Text = textBox1.Text.Length.ToString() + 
                              " … 文字数が足りません";
            }
            else
            {
                label3.Text = textBox1.Text.Length.ToString();
            }

        }

 
    }
}
