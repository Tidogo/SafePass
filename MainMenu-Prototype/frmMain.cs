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

            //SqlCommand command = new SqlCommand("SELECT * FROM Users", connection);
            //SqlDataReader sdr = command.ExecuteReader();
            //dataView.DataSource = sdr;
            //dataView.dataBind();

        }

        private void generatePass_Click(object sender, EventArgs e)
        {
            new frmGenPass(id).Show();
            this.Hide();
        }
    }
}
