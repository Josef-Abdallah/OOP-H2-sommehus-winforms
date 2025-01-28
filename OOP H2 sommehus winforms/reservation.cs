using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_H2_sommehus_winforms
{

    public partial class reservation : Form
    {
        databaseSetup databaseSetup = new databaseSetup();
        public string masterConnectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        public string connectionString = "Server=localhost\\SQLEXPRESS;Database=Sommerhus-DB;Trusted_Connection=True;";
        private string tabelString = "resevartion";
        public reservation()
        {
            InitializeComponent();
            databaseSetup.EnsureDatabaseAndTables(tabelString);
            databaseSetup.LoadData(dataGridView1, tabelString);
            LoadSommerhusIdIntoComboBox();
        }

        private void button_opret_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check for overlapping reservations
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM resevartion WHERE sommerHusId = @sommerHusId AND " +
                    "((@StartDato BETWEEN StartDato AND SlutDato) OR (@SlutDato BETWEEN StartDato AND SlutDato) OR " +
                    "(StartDato BETWEEN @StartDato AND @SlutDato) OR (SlutDato BETWEEN @StartDato AND @SlutDato))",
                    connection);
                checkCmd.Parameters.AddWithValue("@sommerHusId", int.Parse(SommerhusId_combobox.Text.Split(':')[0]));
                checkCmd.Parameters.AddWithValue("@StartDato", fromDate.Value);
                checkCmd.Parameters.AddWithValue("@SlutDato", ToDate.Value);

                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("The selected house is already reserved for the specified period.");
                    return;
                }

                // Insert new reservation
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO resevartion (sommerHusId, navn, kontaktinformation, StartDato, SlutDato, IsReserved) " +
                    "VALUES (@sommerHusId, @navn, @kontaktinformation, @StartDato, @SlutDato, @IsReserved)",
                    connection);
                cmd.Parameters.AddWithValue("@sommerHusId", int.Parse(SommerhusId_combobox.Text.Split(':')[0]));
                cmd.Parameters.AddWithValue("@navn", txt_navn.Text);
                cmd.Parameters.AddWithValue("@kontaktinformation", txt_kontaktinformation.Text);
                cmd.Parameters.AddWithValue("@StartDato", fromDate.Value);
                cmd.Parameters.AddWithValue("@SlutDato", ToDate.Value);
                cmd.Parameters.AddWithValue("@IsReserved", true);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation created successfully.");
                databaseSetup.LoadData(dataGridView1, tabelString);
            }
        }


        /// <summary>
        /// Loads all "sommerhusId" into comboBox2.
        /// </summary>
        private void LoadSommerhusIdIntoComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT sommerhusId, navn FROM sommerhus", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SommerhusId_combobox.Items.Add($"{reader["sommerhusId"]}: {reader["navn"]}");
                }
                connection.Close();
            }
        }
        private void txt_navn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }




    }
}
