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
    public partial class frmAdminTools : Form
    {
        public frmAdminTools()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            Hide();
            main.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmAdminPanel admins = new frmAdminPanel();
            Hide();
            admins.Show();
            MessageBox.Show("You have entered into Users menu!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
