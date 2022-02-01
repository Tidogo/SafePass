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

    public partial class Form1 : Form
    {
        // account id stored in this public variable
        public int id = 0;

        // Make the form to use the entered credentials to show only their own data
        public Form1(int loginid)
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
    }
}
