using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VetClinic.View
{
    public partial class frmBreed : Form
    {
        public frmBreed()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.con))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT BreedId, Breed FROM [Breed]", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvBreed.DataSource = dt;

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                string sql = "SELECT VesselId, InternationalNumber FROM [Vessel]";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int CategoryId = reader.GetInt32(0);
                            string Category = reader.GetString(1);

                            cmbCategory.Items.Add(new ComboBoxCategory(Category, CategoryId));
                        }
                    }
                }
            }
        }

        private void dgvReset()
        {
            this.Hide();
            frmBreed frmBreed = new frmBreed();
            frmBreed.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBreed.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Id = (int)dgvBreed.SelectedRows[0].Cells["BreedId"].Value;

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand command = new SqlCommand("DELETE FROM [Breed] WHERE BreedId = @BreedId", con);
                command.Parameters.AddWithValue("@BreedId", Id);

                command.ExecuteNonQuery();

                dgvReset();
                MessageBox.Show("The breed has been deleted successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBreed.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgvBreed.SelectedRows[0];

            int Id = (int)row.Cells["BreedId"].Value;

            string newBreed = txtBreed.Text.Trim();


            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [Breed] WHERE Breed = @Breed AND BreedId <> @BreedId", con);
                checkCommand.Parameters.AddWithValue("@Breed", newBreed);
                checkCommand.Parameters.AddWithValue("@BreedId", Id);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Breed already exists. Please choose a different Breed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [Breed] SET Breed = @Breed WHERE BreedId = @BreedId", con);
                updateCommand.Parameters.AddWithValue("@Breed", newBreed);
                updateCommand.Parameters.AddWithValue("@BreedId", Id);
                updateCommand.ExecuteNonQuery();

                con.Close();
            }

            dgvReset();
            MessageBox.Show("The Breed has been edited successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            Hide();
            main.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string Breed = txtBreed.Text;

            if (string.IsNullOrEmpty(Breed))
            {
                MessageBox.Show("Please enter breed name");
                return;
            }

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                string selectSql = "SELECT COUNT(*) FROM [Breed] WHERE Breed = @Breed";
                string insertSql = "INSERT INTO [Breed] (Breed) VALUES (@Breed)";

                using (SqlCommand selectCommand = new SqlCommand(selectSql, con))
                using (SqlCommand insertCommand = new SqlCommand(insertSql, con))
                {
                    selectCommand.Parameters.AddWithValue("@Breed", Breed);
                    try
                    {
                        con.Open();
                        int count = (int)selectCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show($"Breed {Breed} already exists. Please choose a different breed.");
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
                        MessageBox.Show("An error occurred while creating the breed. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }
        private void dgvBreed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBreed.Rows[e.RowIndex];

                int primaryKey = Convert.ToInt32(row.Cells["BreedId"].Value);
                using (SqlConnection connection = new SqlConnection(Program.con))
                {
                    SqlCommand command = new SqlCommand("SELECT Breed FROM [Breed] WHERE BreedId = @BreedId", connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@BreedId", primaryKey);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string Breed = reader["@Breed"].ToString();
                            txtBreed.Text = Breed;
                            connection.Close();
                        }
                    }
                }
            }
        }

        public class ComboBoxCategory
        {
            public int CategoryId { get; set; }
            public string Category { get; set; }

            public ComboBoxCategory(string category, int categoryId)
            {
                Category = category;
                CategoryId = categoryId;
            }

            public override string ToString()
            {
                return Category;
            }
        }
    }
}
