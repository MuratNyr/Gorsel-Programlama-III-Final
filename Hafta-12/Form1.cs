using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Database1.mdb";
            OleDbConnection connection = new OleDbConnection(connectionString);

            string query = "SELECT * FROM Filmler";

            OleDbCommand command = new OleDbCommand(query, connection);

            connection.Open();

            OleDbDataReader reader = command.ExecuteReader();

            int rowCount = 0;
            int columnCount = 0;
            int maxColumns = 5;

            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel.ForeColor = Color.White;
            tableLayoutPanel.Margin = new Padding(50);
            
            panel3.Controls.Add(tableLayoutPanel);

            while (reader.Read())
            {
                if (columnCount % maxColumns == 0)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    tableLayoutPanel.RowCount++;
                    rowCount++;
                    columnCount = 0;
                }

                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 200;
                pictureBox.Height = 300;
                pictureBox.ImageLocation = reader["ResimUrl"].ToString();

                Label titleLabel = new Label();
                titleLabel.Anchor = AnchorStyles.None;
                titleLabel.AutoSize = false;
                titleLabel.Dock = DockStyle.Bottom;
                titleLabel.TextAlign = ContentAlignment.MiddleCenter;
                titleLabel.Font = new Font(tableLayoutPanel.Font.FontFamily, 15, FontStyle.Bold);
                titleLabel.Location = new Point((this.Width - titleLabel.Width) / 2, (this.Height - titleLabel.Height) / 2);
                titleLabel.Text = reader["FilmAdi"].ToString();

                Panel cardPanel = new Panel();
                cardPanel.AutoSize = false;
                cardPanel.Width = 200;
                cardPanel.Height = 350;

                cardPanel.Controls.Add(pictureBox);
                cardPanel.Controls.Add(titleLabel);

                tableLayoutPanel.Controls.Add(cardPanel, columnCount, rowCount);
                columnCount++;
            }

            reader.Close();
            connection.Close();
            
        }
    }
}
