using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MainMenu_Prototype;
using System.Diagnostics;

namespace MainMenu_Prototype
{
    public partial class frmHelp : Form
    {
        public int identity;
        public frmHelp(int id)
        {
            InitializeComponent();
            identity = id;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_OpenEmail_Click(object sender, EventArgs e)
        {
            var url = "mailto:safepass166@gmail.com";
            Process.Start(url);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmMain(identity).Show();
            this.Hide();
        }

        private void help_goToEdit_Click(object sender, EventArgs e)
        {
            new frmPassAdd(identity).Show();
            this.Hide();
        }

        private void help_goToGenPass_Click(object sender, EventArgs e)
        {
            new frmGenPass(identity).Show();
            this.Hide();
        }

        private void help_goToResMasPass_Click(object sender, EventArgs e)
        {
            new frmResetMasterPass(identity).Show();
            this.Hide();
        }
    }
}
