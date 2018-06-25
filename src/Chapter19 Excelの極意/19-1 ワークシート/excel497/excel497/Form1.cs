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

namespace excel497
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
            var wb = xapp.Workbooks.Open(@"C:\C#2017\data\Book1.xlsx");
            var sh = wb.ActiveSheet as Excel.Worksheet;

            // 終端を探す
            int rmax = 2;
            while (sh.Cells[rmax, 1].Text != "")
            {
                rmax++;
            }
            rmax--;
            // 罫線を書く
            var rg = sh.Range["A1", sh.Cells[rmax, 3]] as Excel.Range;
            rg.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            rg.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            rg.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            rg.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            rg.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
            rg.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;


            rg.Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlThick;
            rg.Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = Excel.XlBorderWeight.xlThick;
            rg.Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = Excel.XlBorderWeight.xlThick;
            rg.Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = Excel.XlBorderWeight.xlThick;
            rg.Borders[Excel.XlBordersIndex.xlInsideHorizontal].Weight = Excel.XlBorderWeight.xlThin;
            rg.Borders[Excel.XlBordersIndex.xlInsideVertical].Weight = Excel.XlBorderWeight.xlThin;
            // 保存する
            wb.SaveAs(@"C:\C#2017\data\BookSave.xlsx");
            MessageBox.Show("保存しました");
            xapp.Quit();
        }
    }
}
