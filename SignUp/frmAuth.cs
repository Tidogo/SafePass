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

namespace LoginRegister
{
    public partial class frmAuth : Form
    {
        public int identity;
        public int authcode;
        public string emailaddress;
        public frmAuth(int id, int code, string email)
        {
            InitializeComponent();
            identity = id;
            authcode = code;
            txtDevAuth.Text = authcode.ToString();
            emailaddress = email;
            Email(authcode.ToString(), emailaddress);
        }

        public static void Email(string htmlString, string accEmail)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("safepass166@gmail.com");
                message.To.Add(new MailAddress(accEmail));
                message.Subject = "Here is your 2FA code!";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = htmlString;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("safepass166@gmail.com", "962x2^CA2q");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtCode.Text) == authcode)
                {
                    MessageBox.Show("Login Successful!");
                    new frmMain(identity).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Code incorrect! Please try again.");
                }
            }
            catch
            {
                ArgumentException ex = new ArgumentException();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResend_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            String r = rand.Next(0, 1000000).ToString("D6");
            int authnum = int.Parse(r);
            Email(authcode.ToString(), emailaddress);
            MessageBox.Show("New code sent!");
        }

        private void txtDevAuth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
