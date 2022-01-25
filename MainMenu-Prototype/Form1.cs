using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu_Prototype
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
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
