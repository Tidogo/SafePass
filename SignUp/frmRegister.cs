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

namespace SafePass_Application
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            // Setting the password to be hidden initially
            txtPassword.PasswordChar = '•';
            txtConfPassword.PasswordChar = '•';
        }
        
        // Show password/Hide password NOT DONE YET
        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {

            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConfPassword.PasswordChar = '•';
            }
        }
        // Clear the entries
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtConfPassword.Text = "";
            txtEmail.Text = "";
            txtEmail.Focus();
        }
        // Go back to Login 
        private void pressBackToLogin_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
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
                    String query = "INSERT INTO Accounts (AccountEmail,AccountPW) VALUES (@amail, @apw)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@amail", txtConfPassword.Text);
                    command.Parameters.AddWithValue("@apw", txtEmail.Text);

                    command.ExecuteNonQuery();
                    new frmLogin().Show();
                    this.Hide();
                }
            }
            catch (SqlException ec)
            {
                Console.WriteLine(ec.ToString());
            }
        }
    }
    }
