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
    public partial class frmPassDelete : Form
    {
        public int id = 0;
        public frmPassDelete(int userid)
        {
            InitializeComponent();
            id = userid;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
          * For the delete user button
          * */

            try
            {
                // default connection string for any connection to safepass-db
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "safepass-serv.database.windows.net";
                builder.UserID = "db-admin";
                builder.Password = "af8kK$T7Da";
                builder.InitialCatalog = "safepass-db";

                // code for generating sql query to delete account info based on user ID from database
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    String query = "DELETE Users WHERE UserID = @uid";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@uid", userid.Text);
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
    }
}
