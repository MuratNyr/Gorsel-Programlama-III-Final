using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            yeniTarih = DateTime.Now;
            dateTimePicker1.Value = yeniTarih;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] klasorler = Directory.GetDirectories(@"C:\Windows\");
            int i = 0;
            foreach (string klasor in klasorler)
            {
                string klasorAdi = Path.GetFileName(klasor);
                ListViewItem item = new ListViewItem(klasorAdi);
                item.ImageIndex = i;
                i++;
                listView1.Items.Add(item);
            }
        }

        private void detayliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void kucukSimgelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void buyukSimgelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = null;
            DateTime seciliTarih = dateTimePicker1.Value;

            textBox1.Text = seciliTarih.ToString("yyyy-MM-dd") + Environment.NewLine;
            textBox1.Text += seciliTarih.ToString("dd/MM/yyyy") + Environment.NewLine;
            textBox1.Text += seciliTarih.ToString("dddd, MMMM dd, yyyy") + Environment.NewLine;
            textBox1.Text += seciliTarih.ToString("HH:mm:ss") + Environment.NewLine;
            textBox1.Text += seciliTarih.ToString("MMMM") + Environment.NewLine;
            textBox1.Text += seciliTarih.ToString("yyyy") + Environment.NewLine;
            textBox1.Text += seciliTarih.ToString("dddd") + Environment.NewLine;
            textBox1.Text += seciliTarih.ToString("ddd") + Environment.NewLine;
            textBox1.Text += seciliTarih.ToString("MM/dd/yy") + Environment.NewLine;
            textBox1.Text += seciliTarih.ToString("yyyy/MM/dd") + Environment.NewLine;
            textBox1.Text += seciliTarih.ToString("HH:mm") + Environment.NewLine;
            textBox1.Text += seciliTarih.ToString("MMMM dd, yyyy") + Environment.NewLine;
            textBox1.Text += seciliTarih.ToString("yyyy/MM/dd HH:mm:ss") + Environment.NewLine;
            textBox1.Text += seciliTarih.ToString("dddd, dd MMMM yyyy") + Environment.NewLine;
            textBox1.Text += seciliTarih.ToString("yyyy MMMM dd") + Environment.NewLine;
        }
        private DateTime yeniTarih;
        private void timer1_Tick(object sender, EventArgs e)
        {
            yeniTarih = yeniTarih.AddMonths(1);
            dateTimePicker1.Value = yeniTarih;
        }
    }
}
