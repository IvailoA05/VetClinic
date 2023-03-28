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
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.con))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Id, Username, Password, IsAdmin, Address, Phone FROM [User]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvVetClinic.DataSource = dt;
        }

        private void dgvReset()
        {
            this.Hide();
            frmAdminPanel frmAdminPanel = new frmAdminPanel();
            frmAdminPanel.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvVetClinic.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Id = (int)dgvVetClinic.SelectedRows[0].Cells["Id"].Value;

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand command = new SqlCommand("DELETE FROM [User] WHERE Id = @Id", con);
                command.Parameters.AddWithValue("@Id", Id);

                command.ExecuteNonQuery();

                dgvReset();
                MessageBox.Show("The account has been deleted successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvVetClinic.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgvVetClinic.SelectedRows[0];

            int Id = (int)row.Cells["Id"].Value;

            string newUsername = txtUsername.Text.Trim();
            string newPassword = txtPassword.Text.Trim();
            bool IsAdmin = chBoxIsAdmin.Checked;

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [User] WHERE Username = @Username AND Id <> @Id", con);
                checkCommand.Parameters.AddWithValue("@Username", newUsername);
                checkCommand.Parameters.AddWithValue("@Id", Id);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [User] SET Username = @Username, Password = @Password, isAdmin = @IsAdmin WHERE Id = @Id", con);
                updateCommand.Parameters.AddWithValue("@Username", newUsername);
                updateCommand.Parameters.AddWithValue("@Password", newPassword);
                updateCommand.Parameters.AddWithValue("@IsAdmin", IsAdmin);
                updateCommand.Parameters.AddWithValue("@Id", Id);
                updateCommand.ExecuteNonQuery();

                con.Close();
            }

            dgvReset();
            MessageBox.Show("The account has been edited successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister reg = new frmRegister();
            Hide();
            reg.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            Hide();
            main.Show();
        }
    }
}
