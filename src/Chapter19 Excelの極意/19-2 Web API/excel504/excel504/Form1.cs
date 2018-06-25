using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace excel504
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var url = "http://www.shuwasystem.co.jp/";
            var hc = new HttpClient();
            var html = await hc.GetStringAsync(url);
            var hdoc = new HtmlAgilityPack.HtmlDocument();
            hdoc.LoadHtml(html);
            var lst = hdoc.DocumentNode.SelectNodes("//img[@alt='新刊']");
            var items = new List<string>();
            var books = new List<Book>();
            foreach ( var it in lst )
            {
                var text = it.ParentNode.SelectSingleNode("a").InnerText.Trim();
                items.Add(text);
                var link = it.ParentNode.SelectSingleNode("a").GetAttributeValue("href","");
                books.Add(new Book() { Title = text, Link = link });
            }
            listBox1.DataSource = items;
            // excel に出力
            var xapp = new Excel.Application();
            var wb = xapp.Workbooks.Add();
            var sh = wb.ActiveSheet as Excel.Worksheet;
            sh.Cells[1, 1].Value = "タイトル";
            sh.Cells[1, 2].Value = "リンク";
            int r = 2;
            foreach ( var it in books )
            {
                sh.Cells[r, 1].Value = it.Title;
                sh.Cells[r, 2].Value = it.Link;
                r++;
            }
            xapp.Visible = true;
            xapp.Quit();


        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Link { get; set; }
    }
}
