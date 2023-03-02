using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister reg = new frmRegister();
            Hide();
            reg.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = User.GetUser(txtUsername.Text);
            if(password == txtPassword.Text)
            {
                MessageBox.Show("Succesfully logged in!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
