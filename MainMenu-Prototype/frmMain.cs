using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace MainMenu_Prototype
{

    public partial class frmMain : System.Windows.Forms.Form
    {
        // account id stored in this public variable
        public int id = 0;

        // Make the form to use the entered credentials to show only their own data
        public frmMain(int loginid)
        {
            InitializeComponent();
            id = loginid;
            this.Load += new EventHandler(dataView_Load);
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

        private void dataView_Load(object sender, EventArgs e)
        {
            dataView.DataSource = GetUserList();
        }

        private DataTable GetUserList()
        {
            DataTable dtTable = new DataTable();

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "safepass-serv.database.windows.net";
            builder.UserID = "db-admin";
            builder.Password = "af8kK$T7Da";
            builder.InitialCatalog = "safepass-db";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String query = "SELECT UserEmail,UserPW,Category, ServiceURL, Notes FROM Users WHERE AccountID LIKE @acID";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@acID",SqlDbType.VarChar);
                command.Parameters["@acID"].Value = id;

                SqlDataReader reader = command.ExecuteReader();
                dtTable.Load(reader);
            }
            return dtTable;

        }

    }
}
