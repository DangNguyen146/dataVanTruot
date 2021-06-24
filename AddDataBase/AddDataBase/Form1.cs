using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddDataBase
{
    public partial class Form1 : Form
    {
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            maVan.Text = index++.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            maVan.Text = index++.ToString();
            richTextBox1.Text += ",\n"+"{\n";
            richTextBox1.Text += '"' + "maVan" + '"' + ":" + maVan.Text + "," + "\n";
            richTextBox1.Text += '"' + "tenVan" + '"' + ":" + '"' + tenVan.Text + '"' + "," + "\n";
            richTextBox1.Text += '"' + "giaVan" + '"' + ":" + '"' + giaVan.Text + '"' + "," + "\n";
            richTextBox1.Text += '"' + "hinhAnh" + '"' + ": " + '"' + "https://bizweb.dktcdn.net/thumb/medium/100/345/407/products/"  + hinhAnh.Text + '"' + "," + "\n";
            richTextBox1.Text += '"' + "moTa" + '"' + ":" + '"' + tenVan.Text + '"' + "," + "\n";
            richTextBox1.Text += '"' + "danhGia" + '"' + ":" + danhGia.Text + "\n";
            richTextBox1.Text += "}";
            giaVan.Text = "";
            tenVan.Text = "";
            hinhAnh.Text = "";
        }
    }
}
