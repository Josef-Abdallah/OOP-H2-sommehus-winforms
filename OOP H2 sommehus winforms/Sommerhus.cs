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
    public partial class Sommerhus : Form
    {
        public string connectionString = "Server=localhost\\SQLEXPRESS;Database=Sommerhus-DB;Trusted_Connection=True;";

        public Sommerhus()
        {
            InitializeComponent();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * from [sommerhus]", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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
            cmd.Parameters.AddWithValue("@pris",decimal.Parse(txt_pris.Text));
            cmd.Parameters.AddWithValue("@sæson", txt_sæson.Text);
            cmd.Parameters.AddWithValue("@inspektør", txt_inspektør.Text);

            cmd.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Fuldført");
        }

        private void button_Redigere_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            SqlCommand cmd = new SqlCommand("UPDATE[sommerhus] SET navn=@navn, pris=@pris, område=@område, sæson=@sæson, inspektør=@inspektør WHERE navn="+txt_Rnavn+"",connection);
            cmd.Parameters.AddWithValue("@navn", txt_Rnavn.Text);
            cmd.Parameters.AddWithValue("@område", txt_Rområde.Text);
            cmd.Parameters.AddWithValue("@pris", decimal.Parse(txt_Rpris.Text));
            cmd.Parameters.AddWithValue("@sæson", txt_Rsæson.Text);
            cmd.Parameters.AddWithValue("@inspektør", txt_Rinspektør.Text);

            cmd.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("opdateret");

        }
    }
}
