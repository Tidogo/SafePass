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
using MainMenu_Prototype;

namespace MainMenu_Prototype
{
    public partial class frmPassAdd : Form
    {
        public int id = 0;
        public frmPassAdd(int userid)
        {
            InitializeComponent();
            id = userid;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * For the add user button
             * */

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
                    connection.Open();
                    String query = "INSERT INTO Users (UserPW,UserEmail,Category,Notes,AccountID,ServiceName,ServiceURL) " +
                        "VALUES (@upw, @umail, @cat, @notes, @aid, @servname, @servurl)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@upw", txtUserPW.Text);
                    command.Parameters.AddWithValue("@umail", txtUserEmail.Text);
                    command.Parameters.AddWithValue("@cat", txtCategory.Text);
                    command.Parameters.AddWithValue("@notes", txtNotes.Text);
                    command.Parameters.AddWithValue("@aid", id);
                    command.Parameters.AddWithValue("@servname", txtServiceName.Text);
                    command.Parameters.AddWithValue("@servurl", txtServiceURL.Text);
                    command.ExecuteNonQuery();
                    new frmMain(id).Show();
                    this.Hide();
                }
            }
            catch (SqlException ec)
            {
                Console.WriteLine(ec.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
             * For the update user button
             * */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
             * For the delete user button
             * */
        }
    }
}
