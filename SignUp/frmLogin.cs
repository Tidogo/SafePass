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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            // Setting the password to be hidden initially
            txtPassword.PasswordChar = '•';
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // connecting to the database here
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

    }
}
