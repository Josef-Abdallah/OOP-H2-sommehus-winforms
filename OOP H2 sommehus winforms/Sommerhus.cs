﻿using System;
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
            databaseSetup.LoadData(dataGridView1, tabelString);
            SetInitialVisibility();
        }

        /// <summary>
        /// Sets the initial visibility of the form elements to false.
        /// </summary>
        private void SetInitialVisibility()
        {
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

        private void OpretSommerhus_button(object sender, EventArgs e)
        {
            ExecuteNonQuery("INSERT INTO [sommerhus] (navn, pris, område, sæson, inspektør) VALUES (@navn, @pris, @område, @sæson, @inspektør)",
                new SqlParameter("@navn", txt_navn.Text),
                new SqlParameter("@pris", decimal.Parse(txt_pris.Text)),
                new SqlParameter("@område", txt_område.Text),
                new SqlParameter("@sæson", txt_sæson.Text),
                new SqlParameter("@inspektør", txt_inspektør.Text));

            MessageBox.Show("Fuldført");
            databaseSetup.LoadData(dataGridView1,tabelString);
        }

        private void RedigerSommerhus_button(object sender, EventArgs e)
        {
            ExecuteNonQuery("UPDATE [sommerhus] SET navn=@navn, pris=@pris, område=@område, sæson=@sæson, inspektør=@inspektør WHERE navn=@oldNavn",
                new SqlParameter("@navn", txt_Rnavn.Text),
                new SqlParameter("@pris", decimal.Parse(txt_Rpris.Text)),
                new SqlParameter("@område", txt_Rområde.Text),
                new SqlParameter("@sæson", txt_Rsæson.Text),
                new SqlParameter("@inspektør", txt_Rinspektør.Text),
                new SqlParameter("@oldNavn", txt_Rnavn.Text));

            MessageBox.Show("Opdateret");
            databaseSetup.LoadData(dataGridView1,tabelString);
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
            txt_Rsæson.Text = "";
            txt_Rinspektør.Text = "";

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
            txt_Rsæson.Visible = true;
            txt_Rinspektør.Visible = true;

            label11.Visible = true;
            label10.Visible = true;
            label9.Visible = true;
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
