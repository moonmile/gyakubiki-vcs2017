﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excel493
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var xapp = new Microsoft.Office.Interop.Excel.Application();
            var wb = xapp.Workbooks.Open(@"C:\C#2017\data\Book1.xlsx");
            var sh = wb.Sheets[1] as Microsoft.Office.Interop.Excel.Worksheet;
            label1.Text = sh.Range["B2"].Value;
            xapp.Quit();
        }
    }
}
