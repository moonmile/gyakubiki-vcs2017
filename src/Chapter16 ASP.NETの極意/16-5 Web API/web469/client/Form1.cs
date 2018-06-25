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
            var id = textBox1.Text;
            var uri = new Uri("http://localhost:5000/api/Books/" + id);
            var cl = new HttpClient();
            var res = await cl.GetAsync(uri);
            label5.Text = await res.Content.ReadAsStringAsync();
        }
    }
}
