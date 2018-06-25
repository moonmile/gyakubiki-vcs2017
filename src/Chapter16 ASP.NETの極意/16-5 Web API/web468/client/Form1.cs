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

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var uri = new Uri("http://localhost:5000/api/Books/");
            var cl = new HttpClient();
            var dic = new Dictionary<string, string>();
            dic.Add("ID", textBox1.Text);
            dic.Add("Title", textBox2.Text);
            dic.Add("Price", textBox3.Text);
            dic.Add("Pages", textBox4.Text);
            var content = new FormUrlEncodedContent(dic);
            var res = await cl.PostAsync(uri, content);
            label5.Text = await res.Content.ReadAsStringAsync();
        }
    }
}
