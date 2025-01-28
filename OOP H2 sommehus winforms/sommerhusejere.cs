using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
            SetInitialVisibility();
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
            SommerhusejereData sommerhusejere = new SommerhusejereData
            {
                Navn = txt_navn_redigere.Text,
                tlf = txt_tlf_redigere.Text,
                email = txt_email_redigere.Text
            };

            ExecuteNonQuery("UPDATE [sommerhusejere] SET navn=@navn, tlf=@tlf, email=@email WHERE navn=@oldNavn",
                new SqlParameter("@navn", sommerhusejere.Navn),
                new SqlParameter("@tlf", sommerhusejere.tlf),
                new SqlParameter("@email", sommerhusejere.email),
                new SqlParameter("@oldNavn", sommerhusejere.Navn));

            MessageBox.Show("Opdateret");
            databaseSetup.LoadData(dataGridView1, tabelString);
            ResetFormFields();

        }

        private void checkNameButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [sommerhusejere] WHERE navn=@navn", connection);
                cmd.Parameters.AddWithValue("@navn", txt_navn_redigere.Text);
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

        /// <summary>
        /// is being used to show the edit fields so you can edit
        /// </summary>
        private void ShowEditFields()
        {
            txt_tlf_redigere.Visible = true;
            txt_email_redigere.Visible = true;

            label6.Visible = true;
            label1.Visible = true;

            checkNameButton.Visible = false;
            button_redigere.Visible = true;

            txt_navn_redigere.ReadOnly = true; // Lock the text box to prevent editing
        }

        private void ResetFormFields()
        {
            txt_navn_redigere.Text = "";
            txt_tlf_redigere.Text = "";
            txt_email_redigere.Text = "";

            SetInitialVisibility();

            checkNameButton.Visible = true;
            button_redigere.Visible = false;

            txt_navn_redigere.ReadOnly = false; // Unlock the text box for new input
        }

        /// <summary>
        /// Sets the initial visibility of the form elements to false.
        /// </summary>
        private void SetInitialVisibility()
        {
            txt_tlf_redigere.Visible = false;
            txt_email_redigere.Visible = false;

            label6.Visible = false;
            label1.Visible = false;
            button_redigere.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button_CheckName_Click(object sender, EventArgs e)
        {

        }
    }
}
