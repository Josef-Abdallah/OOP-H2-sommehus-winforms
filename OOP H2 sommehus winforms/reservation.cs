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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

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
            SetInitialVisibility();
            LoadSommerhusIdIntoComboBox();
        }

        private void button_opret_Click(object sender, EventArgs e)
        {
            if (fromDate.Value > ToDate.Value)
            {
                MessageBox.Show("Start date cannot be after the end date.");
                return;
            }

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

                // Create a new customer object
                Customer customer = new Customer
                {
                    Navn = txt_navn.Text,
                    tlfNummer = txt_kontaktinformation.Text
                };

                // Insert new reservation
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO resevartion (sommerHusId, navn, kontaktinformation, StartDato, SlutDato, IsReserved) " +
                    "VALUES (@sommerHusId, @navn, @kontaktinformation, @StartDato, @SlutDato, @IsReserved)",
                    connection);
                cmd.Parameters.AddWithValue("@sommerHusId", int.Parse(SommerhusId_combobox.Text.Split(':')[0]));
                cmd.Parameters.AddWithValue("@navn", customer.Navn);
                cmd.Parameters.AddWithValue("@kontaktinformation", customer.tlfNummer);
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
                    comboBox_RsommerhusId.Items.Add($"{reader["sommerhusId"]}: {reader["navn"]}");
                }
                connection.Close();
            }
        }

        private void StartsideBut_Click(object sender, EventArgs e)
        {
            startside ss = new startside();
            ss.Show();
            Visible = false;
        }

        private void button_Redigere_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [resevartion] SET sommerHusId=@sommerHusId, navn=@navn, kontaktinformation=@kontaktinformation, StartDato=@StartDato, SlutDato=@SlutDato, IsReserved=@IsReserved WHERE navn=@Navn", connection);
                cmd.Parameters.AddWithValue("@sommerHusId", int.Parse(comboBox_RsommerhusId.Text.Split(':')[0]));
                cmd.Parameters.AddWithValue("@navn", txt_Rnavn.Text);
                cmd.Parameters.AddWithValue("@kontaktinformation", txt_Rtlf.Text);
                cmd.Parameters.AddWithValue("@StartDato", fromDateR.Value);
                cmd.Parameters.AddWithValue("@SlutDato", ToDateR.Value);
                cmd.Parameters.AddWithValue("@IsReserved", true);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Opdateret");
                databaseSetup.LoadData(dataGridView1, tabelString);
                ResetFormFields();
            }
        }
        private void SetInitialVisibility()
        {
            txt_Rtlf.Visible = false;
            fromDateR.Visible = false;
            ToDateR.Visible = false;
            comboBox_RsommerhusId.Visible = false;

            label7.Visible = false;
            label6.Visible = false;
            label5.Visible = false;

            button_FindReservedHouse.Visible = true;
            button_Redigere.Visible = false;
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM [resevartion] WHERE navn=@navn", connection);
                cmd.Parameters.AddWithValue("@navn", txt_Snavn.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Slettet");
                databaseSetup.LoadData(dataGridView1, tabelString);
            }
        }
        private void ResetFormFields()
        {
            txt_Rnavn.Text = "";
            txt_Rtlf.Text = "";
            comboBox_RsommerhusId.Text = "";

            SetInitialVisibility();

            button_FindReservedHouse.Visible = true;
            button_Redigere.Visible = false;

            txt_Rnavn.ReadOnly = false; // Unlock the text box for new input
        }
        private void button_FindReservedHouse_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [resevartion] WHERE navn=@navn", connection);
                cmd.Parameters.AddWithValue("@navn", txt_Rnavn.Text);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    ShowEditFields();
                    MessageBox.Show("Navn fundet, nu kan du redigere sommerhus");
                }
                else
                {
                    MessageBox.Show("Navn ikke fundet");
                }
                connection.Close();
            }
        }
        private void ShowEditFields()
        {
            txt_Rnavn.Visible = true;
            txt_Rtlf.Visible = true;
            fromDateR.Visible = true;
            ToDateR.Visible = true;
            comboBox_RsommerhusId.Visible = true;

            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;

            button_FindReservedHouse.Visible = false;
            button_Redigere.Visible = true;

            txt_Rnavn.ReadOnly = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }

}
