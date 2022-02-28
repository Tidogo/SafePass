using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MainMenu_Prototype;
using System.Text.RegularExpressions;

namespace MainMenu_Prototype
{
    public partial class frmResetMasterPass : Form
    {
        public int identity;
        public frmResetMasterPass(int id)
        {
            InitializeComponent();
            identity = id;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmMain(identity).Show();
            this.Hide();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtConfNewPass.Text == txtNewPass.Text)
            {
                try
                {
                    // default connection string for any connection to safepass-db
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.DataSource = "safepass-serv.database.windows.net";
                    builder.UserID = "db-admin";
                    builder.Password = "af8kK$T7Da";
                    builder.InitialCatalog = "safepass-db";

                    // code for generating sql query to insert new account into database
                    using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                    {
                        connection.Open();
                        String query = "UPDATE Accounts SET AccountPW = @apw WHERE AccountID = @id";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@apw", txtConfNewPass.Text);
                        command.Parameters.AddWithValue("@id", identity);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Password changed successfully!");
                        new frmMain(identity).Show();
                        connection.Close();
                        this.Hide();
                    }
                }
                catch (SqlException ec)
                {
                    Console.WriteLine(ec.ToString());
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match!");
            }
            

        }
    }
}
