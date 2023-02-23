using Microsoft.VisualBasic.Logging;
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

namespace VetClinic.View
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        SqlCommand Scommand;
        SqlConnection Sconnect;
        SqlDataReader Sdararead;

        private void Registration_Load(object sender, EventArgs e)
        {
            Sconnect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Visual Studio Programs\VetClinic\VetClinic\Controller\VetClinicDB.mdf;Integrated Security=True");
            Sconnect.Open();
        }


        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != string.Empty || txtUsername.Text != string.Empty || txtConfirm.Text != string.Empty)
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                    Scommand = new SqlCommand("select * from User where username='" + txtUsername.Text + "'", Sconnect);
                    Sdararead = Scommand.ExecuteReader();

                    if (Sdararead.Read())
                    {
                        Sdararead.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Sdararead.Close();
                        Scommand = new SqlCommand("insert into User values(@username,@password)", Sconnect);
                        Scommand.Parameters.AddWithValue("username", txtUsername.Text);
                        Scommand.Parameters.AddWithValue("password", txtPassword.Text);
                        Scommand.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    Sdararead.Close();
                    MessageBox.Show("The passwords don't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Sdararead.Close();
                MessageBox.Show("Plese fill all fields. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
    }
}
