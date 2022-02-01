﻿using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            // Setting the password to be hidden initially
            txtPassword.PasswordChar = '•';
        }


        // Clear the entries
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
        }

        // Hiding the password
        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        // Go to Register Window
        private void pressCreateAcc_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            try
            {
                // default connection string for any connection to safepass-db
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "safepass-serv.database.windows.net";
                builder.UserID = "db-admin";
                builder.Password = "af8kK$T7Da";
                builder.InitialCatalog = "safepass-db";

                // code for finding and grabbing id of account which user entered credentials for
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    String query = "SELECT * FROM Accounts WHERE AccountEmail LIKE @acemail AND AccountPW LIKE @acpw";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@acemail", SqlDbType.VarChar);
                    command.Parameters.AddWithValue("@acpw", SqlDbType.VarChar);
                    command.Parameters["@acemail"].Value = username;
                    command.Parameters["@acpw"].Value = password;
                    if (command.ExecuteScalar() == null)
                    {
                        MessageBox.Show("Login Failed!");
                    }
                    else
                    {
                        int id = (int)command.ExecuteScalar();
                        MessageBox.Show("Login Successful!");
                        //MessageBox.Show(id.ToString());
                        // Opening a new main menu window
                        this.Hide();
                        // pass account id found in db to main menu
                        new Form1(id).Show();
                    }
                }
            }
            catch (SqlException ec)
            {
                Console.WriteLine(ec.ToString());
            }
        }
    }
}
