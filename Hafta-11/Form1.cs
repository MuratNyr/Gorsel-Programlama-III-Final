using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabanim.mdb";

        public void datagetir()
        {
            string filmSorgusu = "SELECT * FROM Filmler";
            DataTable filmTable = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(filmSorgusu, connection);
                adapter.Fill(filmTable);
            }
            dataGridViewFilmler.DataSource = filmTable;



            string oyuncuSorgusu = "SELECT * FROM Oyuncular";
            DataTable oyuncuTable = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(oyuncuSorgusu, connection);
                adapter.Fill(oyuncuTable);
            }
            dataGridViewOyuncular.DataSource = oyuncuTable;
            comboBoxOyuncular.DataSource = oyuncuTable;
            comboBoxOyuncular.ValueMember = "OyuncuID";
            comboBoxOyuncular.DisplayMember = "OyuncuAdi";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            datagetir();
        }

        private void dataGridViewFilmler_SelectionChanged(object sender, EventArgs e)
        {
            lblHata.Text = null;
            try
            {
                if (dataGridViewFilmler.SelectedRows.Count > 0 && dataGridViewFilmler.SelectedRows != null)
                {
                    int selectedFilmID = Convert.ToInt32(dataGridViewFilmler.SelectedRows[0].Cells["FilmID"].Value);

                    string oyuncularSorgusu = "SELECT * FROM Oyuncular WHERE OyuncuID IN " +
                                              "(SELECT OyuncuID FROM FilmOyunculari WHERE FilmID = @FilmID)";

                    DataTable oyuncuTable = new DataTable();

                    using (OleDbConnection connection = new OleDbConnection(connectionString))
                    {
                        connection.Open();

                        using (OleDbCommand command = new OleDbCommand(oyuncularSorgusu, connection))
                        {
                            command.Parameters.AddWithValue("@FilmID", selectedFilmID);

                            using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                            {
                                adapter.Fill(oyuncuTable);
                            }
                        }
                    }
                    dataGridViewOyuncular.DataSource = oyuncuTable;
                }
            }
            catch (Exception)
            {
                lblHata.Text = "Listelerken bir hata ile karsilasildi...";
                dataGridViewOyuncular.DataSource = null;
            }
        }
        public int selectedOyuncuID;
        private void comboBoxOyuncular_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (comboBoxOyuncular.SelectedItem != null)
            {
                DataRowView selectedOyuncu = comboBoxOyuncular.SelectedItem as DataRowView;
                if (selectedOyuncu != null)
                {
                    selectedOyuncuID = Convert.ToInt32(selectedOyuncu["OyuncuID"]);
                }
            }
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string filmInsertSorgusu = "INSERT INTO Filmler (FilmAdi, Yonetmen, Yil) VALUES (@FilmAdi, @Yonetmen, @Yil)";
                    OleDbCommand filmInsertCommand = new OleDbCommand(filmInsertSorgusu, connection);
                    filmInsertCommand.Parameters.AddWithValue("@FilmAdi", textBox1.Text);
                    filmInsertCommand.Parameters.AddWithValue("@Yonetmen", textBox2.Text);
                    filmInsertCommand.Parameters.AddWithValue("@Yil", Convert.ToInt32(textBox3.Text));
                    filmInsertCommand.ExecuteNonQuery();

                    string filmIDSorgusu = "SELECT @@IDENTITY";
                    OleDbCommand filmIDCommand = new OleDbCommand(filmIDSorgusu, connection);
                    int filmID = Convert.ToInt32(filmIDCommand.ExecuteScalar());

                    string filmOyuncuInsertSorgusu = "INSERT INTO FilmOyunculari (FilmID, OyuncuID) VALUES (@FilmID, @OyuncuID)";
                    OleDbCommand filmOyuncuInsertCommand = new OleDbCommand(filmOyuncuInsertSorgusu, connection);
                    filmOyuncuInsertCommand.Parameters.AddWithValue("@FilmID", filmID);
                    filmOyuncuInsertCommand.Parameters.AddWithValue("@OyuncuID", Convert.ToInt32(comboBoxOyuncular.SelectedValue));
                    filmOyuncuInsertCommand.ExecuteNonQuery();

                    datagetir();
                }
            }
            catch (Exception)
            {
                lblHata.Text = "Listelerken bir hata ile karsilasildi...";
                dataGridViewOyuncular.DataSource = null;
            }
        }
    }
}
