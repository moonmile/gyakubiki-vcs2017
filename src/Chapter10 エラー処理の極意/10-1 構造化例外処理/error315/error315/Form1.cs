﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace error315
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            try
            {
                a = int.Parse("間違った値");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "エラー発生");
            }
        }
    }
}
