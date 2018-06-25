using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app479
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // レジストリへ書き出す
            RegistryKey key = Registry.CurrentUser;
            key = key.CreateSubKey(@"software\逆引き大全C#2017");
            key.SetValue("sample", textBox1.Text);
            key.Close();
            MessageBox.Show("レジストリへ書き込みました");
        }
    }
}
