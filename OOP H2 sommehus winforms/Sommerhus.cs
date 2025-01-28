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
        databaseSetup databaseSetup = new databaseSetup();

        public string masterConnectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        public string connectionString = "Server=localhost\\SQLEXPRESS;Database=Sommerhus-DB;Trusted_Connection=True;";
        private string tabelString = "sommerhus";


        public Sommerhus()
        {
            InitializeComponent();
            databaseSetup.EnsureDatabaseAndTables(tabelString);
            databaseSetup.LoadData(dataGridView1);

            txt_Rpris.Visible = false;
            txt_Rområde.Visible = false;
            txt_Rsæson.Visible = false;
            txt_Rinspektør.Visible = false;

            label11.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            label8.Visible = false;
            button_Redigere.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_opret_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO [sommerhus] (navn, pris, område, sæson, inspektør) VALUES (@navn, @pris, @område, @sæson, @inspektør)", connection);
            cmd.Parameters.AddWithValue("@navn", txt_navn.Text);
            cmd.Parameters.AddWithValue("@område", txt_område.Text);
            cmd.Parameters.AddWithValue("@pris", decimal.Parse(txt_pris.Text));
            cmd.Parameters.AddWithValue("@sæson", txt_sæson.Text);
            cmd.Parameters.AddWithValue("@inspektør", txt_inspektør.Text);

            cmd.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Fuldført");
            databaseSetup.LoadData(dataGridView1);
        }

        private void button_Redigere_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            SqlCommand cmd = new SqlCommand("UPDATE[sommerhus] SET navn=@navn, pris=@pris, område=@område, sæson=@sæson, inspektør=@inspektør WHERE navn='" + txt_Rnavn.Text + "'", connection);
            cmd.Parameters.AddWithValue("@navn", txt_Rnavn.Text);
            cmd.Parameters.AddWithValue("@område", txt_Rområde.Text);
            cmd.Parameters.AddWithValue("@pris", decimal.Parse(txt_Rpris.Text));
            cmd.Parameters.AddWithValue("@sæson", txt_Rsæson.Text);
            cmd.Parameters.AddWithValue("@inspektør", txt_Rinspektør.Text);

            cmd.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("opdateret");
            databaseSetup.LoadData(dataGridView1);

        }
        private void Sommerhus_Load(object sender, EventArgs e)
        {

        }

        private void button_Slet_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM [sommerhus] WHERE navn=@navn", connection);
            cmd.Parameters.AddWithValue("@navn", txt_Snavn.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Slettet");
            databaseSetup.LoadData(dataGridView1);
        }

        private void StartsideBut_Click(object sender, EventArgs e)
        {
            startside ss = new startside();
            ss.Show();
            Visible = false;
        }

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
                    // Execute the desired code if the name is found
                    txt_Rpris.Visible = true;
                    txt_Rområde.Visible = true;
                    txt_Rsæson.Visible = true;
                    txt_Rinspektør.Visible = true;

                    label11.Visible = true;
                    label10.Visible = true;
                    label9.Visible = true;
                    label8.Visible = true;

                    button1.Visible = false;
                    button_Redigere.Visible = true;

                    txt_Rnavn.ReadOnly = true; // Lock the text box to prevent editing
                    MessageBox.Show("Navn fundet, nu kan du redigere sommerhus");
                }
                else
                {
                    MessageBox.Show("Navn ikke fundet");
                }
                connection.Close();
            }
        }
    }
}
