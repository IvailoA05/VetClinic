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
using VetClinic.Controller;

namespace VetClinic.View
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                User.createUser(txtUsername.Text, txtPassword.Text, txtConfirm.Text, chBoxIsAdmin.Checked);
                this.Hide();
                frmAdminPanel admin = new frmAdminPanel();
                admin.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdminPanel admin = new frmAdminPanel();
            Hide();
            admin.Show();
        }
    }
}
