using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta_13
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }

        private void formAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm1 childForm = new ChildForm1();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 5;
            }
            dateTimePicker1.Value = DateTime.Now;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1.0)
            {
                this.Opacity += 0.01;
            }
            else
            {
                timer2.Stop();
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Yellow;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.PaleTurquoise;
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Yellow;
        }

        private void richTextBox1_MouseEnter(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.PaleTurquoise;
        }

        private void AnaForm_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void AnaForm_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
