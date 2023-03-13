using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VetClinic.Controller
{
    internal class User
    {
        public static string GetUser(string username)
        {
            string password = "";
            using (SqlConnection con = new SqlConnection(Program.con))
           
            {
                con.Open();
                string sqlquery = "SELECT * FROM [User] WHERE username = @UName";
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
        private static Regex validatePassword = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$");
        public static void createUser(string username, string password, string cnfmpass, bool isAdmin)
        {
            SqlConnection con = new SqlConnection(Program.con);
                con.Open();
            if (cnfmpass != string.Empty || password != string.Empty || password != string.Empty)
            {
                if (password == cnfmpass)
                {
                    SqlCommand comm = new SqlCommand("select * from [User] where username='" + username + "'", con);
                    SqlDataReader datareader = comm.ExecuteReader();
                    if (datareader.Read())
                    {
                        datareader.Close();
                        con.Close();
                        throw new Exception("Username Already exist please try another");
                    }
                    else if (password.Length < 8)
                    {
                        MessageBox.Show("Password must be at least 8 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (validatePassword.IsMatch(password))
                    {
                        datareader.Close();



                        comm = new SqlCommand("insert into [User] values(@username,@password, @IsAdmin)", con);
                        comm.Parameters.AddWithValue("username", username);
                        comm.Parameters.AddWithValue("password", password);
                        comm.Parameters.AddWithValue("IsAdmin", isAdmin);
                        comm.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created, and can be used.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        con.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Password must contain at least one uppercase character, one lowercase character and a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    con.Close();
                    throw new Exception("Please enter both password same.");
                }
            }
            else
            {
                con.Close();
                throw new Exception("Please enter value in all field.");
            }
        }
    }
}
