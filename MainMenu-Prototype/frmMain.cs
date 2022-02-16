using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;


namespace MainMenu_Prototype
{

    public partial class frmMain : Form
    {
        // account id stored in this public variable
        public int id = 0;

        // Make the form to use the entered credentials to show only their own data
        public frmMain(int loginid)
        {
            InitializeComponent();
            id = loginid;
        }

        //Event handler for search box in main menu
        //Click on searchbox will remove "Search Vault"
        //to allow new entry.
        private void searchBox_Click(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search Vault")
            {
                searchBox.Text = " ";
            } else if (string.IsNullOrEmpty(searchBox.Text))
            {
                searchBox.Text = "Search Vault";
            }
        }

        private void addEntryButton_Click(object sender, EventArgs e)
        {
            new frmPassAdd(id).Show();
            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bindData();
        }

        void bindData()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "safepass-serv.database.windows.net";
            builder.UserID = "db-admin";
            builder.Password = "af8kK$T7Da";
            builder.InitialCatalog = "safepass-db";

            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT UserEmail,UserPW,ServiceName,Category,Notes FROM Users", connection);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataView.DataSource = dt;
        }

        private void generatePass_Click(object sender, EventArgs e)
        {
            new frmGenPass(id).Show();
            this.Hide();
        }

        private void dataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dataView.CurrentRow != null)
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
                        if (id == 0)
                        {
                            connection.Open();

                            DataGridViewRow curRow = dataView.CurrentRow;
                            String query = "INSERT INTO Users (UserPW,UserEmail,Category,Notes,AccountID,ServiceName,ServiceURL) " +
                                "VALUES (@upw, @umail, @cat, @notes, @aid, @servname, @servurl)";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@upw", curRow.Cells["passwordCol"].Value);
                            command.Parameters.AddWithValue("@umail", curRow.Cells["usernameCol"].Value);
                            command.Parameters.AddWithValue("@cat", curRow.Cells["categoryCol"].Value);
                            command.Parameters.AddWithValue("@notes", curRow.Cells["noteCol"].Value);
                            command.Parameters.AddWithValue("@aid", id);
                            command.Parameters.AddWithValue("@servname", curRow.Cells["serviceCol"].Value);
                            command.Parameters.AddWithValue("@servurl", curRow.Cells["usernameCol"].Value);

                        
                            command.ExecuteNonQuery();
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
}
