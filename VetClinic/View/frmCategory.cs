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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.con))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT CategoryId, Category FROM [Category]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvCategory.DataSource = dt;
        }

        private void dgvReset()
        {
            this.Hide();
            frmCategory frmCategory = new frmCategory();
            frmCategory.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Id = (int)dgvCategory.SelectedRows[0].Cells["CategoryId"].Value;

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand command = new SqlCommand("DELETE FROM [Category] WHERE CategoryId = @CategoryId", con);
                command.Parameters.AddWithValue("@CategoryId", Id);

                command.ExecuteNonQuery();

                dgvReset();
                MessageBox.Show("The category has been deleted successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCategory.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgvCategory.SelectedRows[0];

            int Id = (int)row.Cells["CategoryId"].Value;

            string newCategory = txtCategory.Text.Trim();


            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [Category] WHERE Category = @Category AND CategoryId <> @CategoryId", con);
                checkCommand.Parameters.AddWithValue("@Category", newCategory);
                checkCommand.Parameters.AddWithValue("@CategoryId", Id);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Category already exists. Please choose a different category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [Category] SET Category = @Category WHERE CategoryId = @CategoryId", con);
                updateCommand.Parameters.AddWithValue("@Category", newCategory);
                updateCommand.Parameters.AddWithValue("@CategoryId", Id);
                updateCommand.ExecuteNonQuery();

                con.Close();
            }

            dgvReset();
            MessageBox.Show("The Category has been edited successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string Category = txtCategory.Text;

            if (string.IsNullOrEmpty(Category))
            {
                MessageBox.Show("Please enter Category name");
                return;
            }

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                string selectSql = "SELECT COUNT(*) FROM [Category] WHERE Category = @Category";
                string insertSql = "INSERT INTO [Category] (Category) VALUES (@Category)";

                using (SqlCommand selectCommand = new SqlCommand(selectSql, con))
                using (SqlCommand insertCommand = new SqlCommand(insertSql, con))
                {
                    selectCommand.Parameters.AddWithValue("@Category", Category);
                    try
                    {
                        con.Open();
                        int count = (int)selectCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show($"Category {Category} already exists. Please choose a different Category.");
                        }
                        else
                        {
                            int result = insertCommand.ExecuteNonQuery();
                            if (result > 0)
                            {
                                dgvReset();
                            }
                            else
                            {
                                MessageBox.Show("Creation failed. Please try again.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while creating the Category. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            Hide();
            main.Show();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCategory.Rows[e.RowIndex];

                int primaryKey = Convert.ToInt32(row.Cells["CategoryId"].Value);
                using (SqlConnection connection = new SqlConnection(Program.con))
                {
                    SqlCommand command = new SqlCommand("SELECT Category FROM [Category] WHERE CategoryId = @CategoryId", connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@CategoryId", primaryKey);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string Category = reader["@Category"].ToString();
                            txtCategory.Text = Category;
                            connection.Close();
                        }
                    }
                }
            }
        }
    }
}
