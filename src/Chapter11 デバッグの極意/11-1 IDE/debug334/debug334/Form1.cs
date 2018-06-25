using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace debug334
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pa = new Person
            {
                Name = "増田智明",
                Age = 45,
                City = "板橋区"
            };
            pa.Xml = new XElement(
                "person",
                new XElement("Name", "増田智明"),
                new XElement("Age", "45"),
                new XElement("City", "板橋区"));

            label1.Text = pa.ToString();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public XElement Xml;
    }
}
