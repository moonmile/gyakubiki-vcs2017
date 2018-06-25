﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui078
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime(2000, 1, 1);
            DateTime dt2 = new DateTime(2020, 12, 31);

            dateTimePicker1.Format = DateTimePickerFormat.Long;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.MinDate = dt1;
            dateTimePicker1.MaxDate = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = dateTimePicker1.Value.ToShortDateString();
            label4.Text = dateTimePicker1.Text;
        }
    }
}
