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
using System.Xml.Linq;

namespace OOP_H2_sommehus_winforms
{
    public partial class Sommerhus : Form
    {
        List<string> inspektør = new List<string> { "hans", "peter", "lars", "jens", "mads" };
        databaseSetup databaseSetup = new databaseSetup();

        public string masterConnectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        public string connectionString = "Server=localhost\\SQLEXPRESS;Database=Sommerhus-DB;Trusted_Connection=True;";
        private string tabelString = "sommerhus";
        public Sommerhus()
        {
            InitializeComponent();
            // Create the database and tables if they don't exist
            databaseSetup.EnsureDatabaseAndTables(tabelString);
            // Load the data into the data grid view
            databaseSetup.LoadData(dataGridView1, tabelString);
            // Set the  visibility of the edit fields to false
            SetInitialVisibility();

            // Load "ejere" into comboBox2
            LoadEjereIntoComboBox();

            LoadInspektørIntoComboBox(Inspektør_combobox_opretHus);
            LoadInspektørIntoComboBox(inspektør_redigerhus_combobox);
        }


        /// <summary>
        /// Loads all "ejere" into comboBox2.
        /// </summary>
        private void LoadEjereIntoComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT ejerId, navn FROM sommerhusejere", connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox2.Items.Add($"{reader["ejerId"]}: {reader["navn"]}");
                }
                connection.Close();
            }
        }

        /// <summary>
        /// Sets the initial visibility of the form elements to false.
        /// </summary>
        private void SetInitialVisibility()
        {
            txt_Rpris.Visible = false;
            txt_Rområde.Visible = false;
            inspektør_redigerhus_combobox.Visible = false;

            label11.Visible = false;
            label10.Visible = false;
            label8.Visible = false;
            button_Redigere.Visible = false;
        }



        private void OpretSommerhus_button(object sender, EventArgs e)
        {
            ExecuteNonQuery("INSERT INTO [sommerhus] (ejerId, navn, bynavn, vejnavn, pris, område, inspektør) VALUES (@ejerId, @navn, @bynavn, @vejnavn, @pris, @område, @inspektør)",
                new SqlParameter("@ejerId", comboBox2.SelectedItem.ToString().Split(':')[0].Trim()),
                new SqlParameter("@navn", txt_navn.Text),
                new SqlParameter("@bynavn", ByNavn_OpretHus.Text),
                new SqlParameter("@vejnavn", VejNavn_OpretHus.Text),
                new SqlParameter("@pris", decimal.Parse(txt_pris.Text)),
                new SqlParameter("@område", txt_område.Text),
                new SqlParameter("@inspektør", Inspektør_combobox_opretHus.Text));

            MessageBox.Show("Fuldført");
            databaseSetup.LoadData(dataGridView1, tabelString);
        }

        private void RedigerSommerhus_button(object sender, EventArgs e)
        {
            ExecuteNonQuery("UPDATE [sommerhus] SET navn=@navn, pris=@pris, område=@område, inspektør=@inspektør WHERE navn=@oldNavn",
                new SqlParameter("@navn", txt_Rnavn.Text),
                new SqlParameter("@pris", decimal.Parse(txt_Rpris.Text)),
                new SqlParameter("@område", txt_Rområde.Text),
                new SqlParameter("@inspektør", inspektør_redigerhus_combobox.Text),
                new SqlParameter("@oldNavn", txt_Rnavn.Text));

            MessageBox.Show("Opdateret");
            databaseSetup.LoadData(dataGridView1, tabelString);
            ResetFormFields();
        }
        private void button_Slet_Click(object sender, EventArgs e)
        {
            ExecuteNonQuery("DELETE FROM [sommerhus] WHERE navn=@navn",
                new SqlParameter("@navn", txt_Snavn.Text));

            MessageBox.Show("Slettet");
            databaseSetup.LoadData(dataGridView1, tabelString);
        }

        private void ResetFormFields()
        {
            txt_Rnavn.Text = "";
            txt_Rområde.Text = "";
            txt_Rpris.Text = "";
            inspektør_redigerhus_combobox.Text = "";

            SetInitialVisibility();

            button1.Visible = true;
            button_Redigere.Visible = false;

            txt_Rnavn.ReadOnly = false; // Unlock the text box for new input
        }

        private void StartsideBut_Click(object sender, EventArgs e)
        {
            startside ss = new startside();
            ss.Show();
            Visible = false;
        }


        /// <summary>
        /// checks if the name is registerd in the database and if so it shows the editable field to edit the sommerhus 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CheckName_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [sommerhus] WHERE navn=@navn", connection);
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

        /// <summary>
        /// is being used to show the edit fields so you can edit
        /// </summary>
        private void ShowEditFields()
        {
            txt_Rpris.Visible = true;
            txt_Rområde.Visible = true;
            inspektør_redigerhus_combobox.Visible = true;

            label11.Visible = true;
            label10.Visible = true;
            label8.Visible = true;

            button1.Visible = false;
            button_Redigere.Visible = true;

            txt_Rnavn.ReadOnly = true; // Lock the text box to prevent editing
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

        private void LoadInspektørIntoComboBox(ComboBox comboBox)
        {
            for (int i = 0; i < inspektør.Count; i++)
            {
                comboBox.Items.Add(inspektør[i]);
            }
        }

        private void txt_Rnavn_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ByNavn_redigerHus_TextChanged(object sender, EventArgs e)
        {

        }
        private void Sommerhus_Load(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
