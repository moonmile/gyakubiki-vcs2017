﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pg142
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dt = DateTime.Now;                //システム日付を取得

            label1.Text = dt.ToLongDateString();  //長い形式の日付
            label2.Text = dt.ToLongTimeString();  //長い形式の時刻
        }
    }
}
