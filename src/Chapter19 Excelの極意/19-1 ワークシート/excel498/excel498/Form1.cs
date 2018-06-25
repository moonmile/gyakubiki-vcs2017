using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace excel498
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var xapp = new Excel.Application();
            var wb = xapp.Workbooks.Open(@"C:\C#2017\data\BookTodo.xlsx");
            var sh = wb.ActiveSheet as Excel.Worksheet;
            // 最終行を取得(1000行までに制限する)
            for ( int r = 2; r<1000; r++ )
            {
                if (sh.Cells[r, 1].Text == "" || sh.Cells[r, 2].Text == textBox1.Text )
                {
                    sh.Cells[r, 1].Value = label1.Text;
                    sh.Cells[r, 2].Value = textBox1.Text;
                    sh.Cells[r, 3].Value = checkBox1.Checked ? "完了" : "未完了";
                    break;
                }
            }
            // 保存する
            wb.Save();
            xapp.Quit();
        }
    }
}
