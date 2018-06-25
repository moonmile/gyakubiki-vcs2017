﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace excel500
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var xapp = new Excel.Application();
            var wb = xapp.Workbooks.Open(@"C:\C#2017\data\Book3.xlsx");
            var sh = wb.Sheets.Add(After: wb.Sheets[wb.Sheets.Count]) as Excel.Worksheet;
            sh.Name = textBox1.Text;

            // 保存する
            wb.Save();
            MessageBox.Show("追加しました");
            xapp.Quit();
        }
    }
}
