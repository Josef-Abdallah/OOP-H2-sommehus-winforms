using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_H2_sommehus_winforms
{
    public partial class sommerhusejere : Form
    {
        databaseSetup databaseSetup = new databaseSetup();

        public string masterConnectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        public string connectionString = "Server=localhost\\SQLEXPRESS;Database=Sommerhus-DB;Trusted_Connection=True;";
        private string tabelString = "sommerhusejere";

        public sommerhusejere()
        {
            InitializeComponent();
            databaseSetup.EnsureDatabaseAndTables(tabelString);
            databaseSetup.LoadData(dataGridView1, tabelString);
        }

        private void button_opret_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [sommerhusejere] (navn,email,tlf) VALUES (@navn, @email,@tlf)", connection);
            cmd.Parameters.AddWithValue("@navn", txt_navn.Text);
            cmd.Parameters.AddWithValue("@tlf", txt_tlf.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);

            cmd.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Fuldført");
            databaseSetup.LoadData(dataGridView1, tabelString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StartsideBut_Click(object sender, EventArgs e)
        {
            startside ss = new startside();
            ss.Show();
            Visible = false;
        }
        private void ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void button_redigere_Click(object sender, EventArgs e)
        {
            {
                SommerhusData sommerhusejere = new SommerhusData
                {
                    Navn = txt_navn_redigere.Text,
                };

                ExecuteNonQuery("UPDATE [sommerhus] SET navn=@navn,tlf=@tlf, email=@email WHERE navn=@oldNavn",
                    new SqlParameter("@navn", sommerhusejere.Navn),
                    new SqlParameter("@tlf", sommerhusejere.Navn),
                    new SqlParameter("@email", sommerhusejere.Navn),
                    new SqlParameter("@oldNavn", sommerhusejere.Navn));



                MessageBox.Show("Opdateret");
                databaseSetup.LoadData(dataGridView1, tabelString);

            }
        }
    }
}
