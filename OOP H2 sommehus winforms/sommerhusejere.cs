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
            databaseSetup.LoadData(dataGridView1,tabelString);
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
            databaseSetup.LoadData(dataGridView1,tabelString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
