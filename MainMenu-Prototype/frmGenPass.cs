using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainMenu_Prototype;
using System.Security.Cryptography;

namespace MainMenu_Prototype
{
    public partial class frmGenPass : Form
    {
        public int identity;
        public frmGenPass(int id)
        {
            identity = id;
            InitializeComponent();
        }

        private void triggerPassGen_Click(object sender, EventArgs e)
        {
            int pLength = (int)passLength.Value;
            richTextBox1.Text = generatePassword(pLength);
        }

        private string generatePassword(int pLength)
        {
            Random random = new Random();
            byte[] rgb = new byte[pLength];
            RNGCryptoServiceProvider rngCrypt = new RNGCryptoServiceProvider();
            rngCrypt.GetBytes(rgb);
            return Convert.ToBase64String(rgb);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                Clipboard.SetText(richTextBox1.Text);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new frmMain(identity).Show();
            this.Close();
        }
    }
}
