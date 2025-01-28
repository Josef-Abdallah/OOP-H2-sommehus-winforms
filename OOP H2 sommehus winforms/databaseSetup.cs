﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_H2_sommehus_winforms
{
    internal class databaseSetup
    {
        public string masterConnectionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
        public string connectionString = "Server=localhost\\SQLEXPRESS;Database=Sommerhus-DB;Trusted_Connection=True;";


        /// <summary>
        /// Ensure that the database and tables are created
        /// </summary>
        public void EnsureDatabaseAndTables()
        {
            try
            {
                // Check if the database exists
                using (SqlConnection masterConnection = new SqlConnection(masterConnectionString))
                {
                    masterConnection.Open();
                    string checkDbQuery = @"
            IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'Sommerhus-DB')
            BEGIN
                CREATE DATABASE [Sommerhus-DB];
            END";
                    using (SqlCommand cmd = new SqlCommand(checkDbQuery, masterConnection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                // Check if the required table exists and create it if needed
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string checkTableQuery = @"
        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = 'sommerhus' AND xtype = 'U')
        BEGIN
            CREATE TABLE [sommerhus] (
                Id INT IDENTITY(1,1) PRIMARY KEY,
                navn NVARCHAR(100) NOT NULL,
                pris DECIMAL(18, 2) NOT NULL,
                område NVARCHAR(100) NOT NULL,
                sæson NVARCHAR(50),
                inspektør NVARCHAR(100)
            );
            END";
                    using (SqlCommand cmd = new SqlCommand(checkTableQuery, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error ensuring database and tables: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadData(DataGridView dataGridView)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * from [sommerhus]", connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    dataGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
