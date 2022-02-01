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

namespace MainMenu_Prototype
{

    public partial class Form1 : Form
    {
        /* SqlConnection con = new SqlConnection("Data Source=safepass-serv.database.windows.net;Initial Catalog=safepass-db;User ID=db-admin;Password=**;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adpt; */

        // Make the form to use the entered credentials to show only their own data
        public Form1()
        {
            InitializeComponent();
        }

        /* public void DisplayValue()
        {
            con.Open();
            adpt = new SqlDataAdapter();
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        } */

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
    }
}
