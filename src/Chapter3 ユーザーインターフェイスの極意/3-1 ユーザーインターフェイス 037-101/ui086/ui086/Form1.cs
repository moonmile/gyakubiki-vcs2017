﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui086
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextAlign == HorizontalAlignment.Right)
            {
                textBox1.TextAlign = HorizontalAlignment.Left;
                toolStripButton1.Checked = false;
            }
            else
            {
                textBox1.TextAlign = HorizontalAlignment.Right;
                toolStripButton1.Checked = true;
            }

        }
    }
}
