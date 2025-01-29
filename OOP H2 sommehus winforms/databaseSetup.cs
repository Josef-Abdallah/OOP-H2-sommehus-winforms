using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
        string checkTableQuery;


        /// <summary>
        /// Ensure that the database and tables are created
        /// </summary>
        public void EnsureDatabaseAndTables(string tabel)
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
                    if (tabel == "sommerhus")
                    {
                        checkTableQuery = $@"
        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = '{tabel}' AND xtype = 'U')
        BEGIN
            CREATE TABLE [{tabel}] (
                sommerHusId INT IDENTITY(1,1) PRIMARY KEY, 
                ejerId INT NOT NULL FOREIGN KEY REFERENCES [sommerhusejere](ejerId),
                navn NVARCHAR(100) NOT NULL,
                bynavn NVARCHAR(50) NOT NULL,
                vejnavn NVARCHAR(50) NOT NULL,
                pris DECIMAL(18, 2) NOT NULL,
                område NVARCHAR(100) NOT NULL,
                inspektør NVARCHAR(100)
            );
            END";
                    }
                    else if (tabel == "sommerhusejere")
                    {
                        checkTableQuery = $@"
        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = '{tabel}' AND xtype = 'U')
        BEGIN
            CREATE TABLE [{tabel}] (
                ejerId INT IDENTITY(1,1) PRIMARY KEY,
                navn NVARCHAR(100) NOT NULL,
                email NVARCHAR(100) NOT NULL,
                tlf NVARCHAR(100) NOT NULL
            );
            END";
                    }
                    else if (tabel == "resevartion")
                    {
                        checkTableQuery = $@"
        IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = '{tabel}' AND xtype = 'U')
        BEGIN
            CREATE TABLE [{tabel}] (
                 Id INT IDENTITY(1,1) PRIMARY KEY,
                sommerHusId INT NOT NULL FOREIGN KEY REFERENCES [sommerhus](sommerHusId),
                navn NVARCHAR(100) NOT NULL,
                kontaktinformation NVARCHAR(100) NOT NULL,
                StartDato DATETIME NOT NULL,
                SlutDato DATETIME NOT NULL,
                IsReserved BIT NOT NULL DEFAULT 0,
                Price DECIMAL(18, 2) NOT NULL
            );
            END";
                    }
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
        public void DataForDB()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check and insert into sommerhusejere
                string checkEjerQuery = "SELECT COUNT(*) FROM [sommerhusejere] WHERE navn = 'John Doe'";
                SqlCommand checkEjerCmd = new SqlCommand(checkEjerQuery, connection);
                int countEjer = (int)checkEjerCmd.ExecuteScalar();
                if (countEjer == 0)
                {
                    string insertEjerQuery = @"
                INSERT INTO sommerhusejere (navn, email, tlf) 
                VALUES
                ('John Doe', 'john@example.com', '12345678'),
                ('Jane Smith', 'jane@example.com', '87654321'),
                ('Peter Parker', 'peter@dailybugle.com', '99887766');";
                    new SqlCommand(insertEjerQuery, connection).ExecuteNonQuery();
                }
                // Check and insert into sommerhus
                string checkSommerhusQuery = "SELECT COUNT(*) FROM [sommerhus] WHERE navn = 'Beach House'";
                SqlCommand checkSommerhusCmd = new SqlCommand(checkSommerhusQuery, connection);
                int countSommerhus = (int)checkSommerhusCmd.ExecuteScalar();
                if (countSommerhus == 0)
                {
                    string insertSommerhusQuery = @"
                INSERT INTO sommerhus (ejerId, navn, bynavn, vejnavn, pris, område, inspektør) 
                VALUES
                (1, 'Beach House', 'Copenhagen', 'Seaside Road 12', 1500.00, 'Seaside', 'Inspector A'),
                (2, 'Mountain Cabin', 'Aarhus', 'Pine Street 5', 2000.00, 'Mountain', 'Inspector B'),
                (3, 'Lake Cottage', 'Odense', 'Lake View 9', 1750.00, 'Lakeside', 'Inspector C');";
                    new SqlCommand(insertSommerhusQuery, connection).ExecuteNonQuery();
                }

                // Check and insert into resevartion
                string checkReservationQuery = "SELECT COUNT(*) FROM [resevartion] WHERE navn = 'Alice Johnson'";
                SqlCommand checkReservationCmd = new SqlCommand(checkReservationQuery, connection);
                int countReservation = (int)checkReservationCmd.ExecuteScalar();
                if (countReservation == 0)
                {
                    string insertReservationQuery = @"
                INSERT INTO resevartion (sommerHusId, navn, kontaktinformation, StartDato, SlutDato, IsReserved, Price) 
                VALUES
                (1, 'Alice Johnson', 'alice@mail.com', '2025-07-01', '2025-07-10', 1, 1500.00),
                (2, 'Bob Brown', 'bob@mail.com', '2025-08-05', '2025-08-15', 1, 2000.00),
                (3, 'Charlie Davis', 'charlie@mail.com', '2025-09-10', '2025-09-20', 1, 1750.00);";
                    new SqlCommand(insertReservationQuery, connection).ExecuteNonQuery();
                }
            }
        }

        public void LoadData(DataGridView dataGridView,string tabel)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand($"SELECT * from [{tabel}]", connection);
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
