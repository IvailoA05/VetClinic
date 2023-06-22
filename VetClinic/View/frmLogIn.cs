using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VetClinic.Controller;

namespace VetClinic.View
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == string.Empty && password == string.Empty)
            {
                MessageBox.Show("Please enter your username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username == string.Empty)
            {
                MessageBox.Show("Please enter your username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password == string.Empty)
            {
                MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(Program.con))
                {
                    SqlCommand command = new SqlCommand("SELECT Id,IsAdmin FROM [User] WHERE Username = @Username AND Password = @Password", connection);

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    int userId = 0;
                    object isAdminObj = false;

                    if (reader.HasRows)
                    {
                        reader.Read();
                        userId = reader.GetInt32(0);
                        isAdminObj = reader.GetBoolean(1);
                    }
                    connection.Close();

                    if (isAdminObj != null && isAdminObj != DBNull.Value)
                    {
                        Program.isAdmin = (bool)isAdminObj;
                        Program.USer_ID = (int)userId;
             
                        if (Program.isAdmin)
                        {
                            
                            this.Hide();
                            frmAdminTools frmAdminTools = new frmAdminTools();
                            frmAdminTools.Show();
                            MessageBox.Show($"Succesfully logged in as admin as {username}!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            this.Hide();
                            frmMain frmMain = new frmMain();
                            frmMain.Show();
                            MessageBox.Show($"Succesfully logged in as {username}!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }   
        }
    }
}
