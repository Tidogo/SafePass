using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfPassword.Text = "";
            txtEmail.Text = "";
            txtUsername.Focus();
        }
        // Go back to Login 
        private void pressBackToLogin_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // template code for adding new account to accounts table in db
            /*try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "safepass-serv.database.windows.net";
                builder.UserID = "db-admin";
                builder.Password = "af8kK$T7Da";
                builder.InitialCatalog = "safepass-db";

                // test connection of database
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    String query = "INSERT INTO dbo.SMS_PW (id,username,password,email) VALUES (@id,@username,@password, @email)";

                    SqlCommand command = new SqlCommand(query, db.Connection);
                    command.Parameters.Add("@id", "abc");
                    command.Parameters.Add("@username", "abc");
                    command.Parameters.Add("@password", "abc");
                    command.Parameters.Add("@email", "abc");

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ec)
            {
                Console.WriteLine(ec.ToString());
            }*/
        }
    }
    }
