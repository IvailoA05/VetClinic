using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinic.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            if (Program.isAdmin)
            {
                btnAdminTools.Visible = true;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmLogIn login = new frmLogIn();
            Hide();
            login.Show();
            MessageBox.Show("You have succesfully logged out!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdminTools_Click(object sender, EventArgs e)
        {
            frmAdminTools tools = new frmAdminTools();
            Hide();
            tools.Show();
            MessageBox.Show("You have entered into Admin Tools menu!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
