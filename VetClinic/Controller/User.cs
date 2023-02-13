using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VetClinic.Controller
{
    internal class User
    {
        static string GetUser(string username)
        {
            string password = "";
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Visual Studio Programs\VetClinic\VetClinic\Controller\VetClinicDB.mdf"";Integrated Security=True"))
            {
                con.Open();
                string sqlquery = "SELECT * FROM Users WHERE username = @UName";
                SqlCommand command = new SqlCommand(sqlquery, con);

                command.Parameters.AddWithValue("@UName", username);
                SqlDataReader sReader = command.ExecuteReader();

                while (sReader.Read())
                {
                    username = sReader["username"].ToString();
                    password = sReader["password"].ToString();
                }
                con.Close();
            }
            return password;
        }
    }
}
