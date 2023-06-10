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
    public partial class frmMedType : Form
    {
        public frmMedType()
        {
            InitializeComponent();
        }
        private void dgvReset()
        {
            this.Hide();
            frmMedType frmMedType = new frmMedType();
            frmMedType.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            Hide();
            main.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string MedType = txtMedType.Text;

            if (string.IsNullOrEmpty(MedType))
            {
                MessageBox.Show("Please enter MedType name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                string selectSql = "SELECT COUNT(*) FROM [MedicationTypes] WHERE Type = @Type";
                string insertSql = "INSERT INTO [MedicationTypes] (Type) VALUES (@Type)";

                using (SqlCommand selectCommand = new SqlCommand(selectSql, con))
                using (SqlCommand insertCommand = new SqlCommand(insertSql, con))
                {
                    selectCommand.Parameters.AddWithValue("@Type", MedType);
                    insertCommand.Parameters.AddWithValue("@Type", MedType);
                    try
                    {
                        con.Open();
                        int count = (int)selectCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show($"MedType {MedType} already exists. Please choose a different MedType.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            int result = insertCommand.ExecuteNonQuery();
                            if (result > 0)
                            {
                                dgvReset();
                                MessageBox.Show($"Successfully added a Medtype {MedType}!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Creation failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while creating the MedType. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMedType.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Id = (int)dgvMedType.SelectedRows[0].Cells["MedTypesId"].Value;

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand command = new SqlCommand("DELETE FROM [MedicationTypes] WHERE MedTypesId = @MedTypesId", con);
                command.Parameters.AddWithValue("@MedTypesId", Id);

                command.ExecuteNonQuery();

                dgvReset();
                MessageBox.Show("The MedType has been deleted successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMedType.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgvMedType.SelectedRows[0];

            int Id = (int)row.Cells["MedTypesId"].Value;

            string newMedType = txtMedType.Text.Trim();


            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [MedicationTypes] WHERE Type = @Type AND MedTypesId <> @MedTypesId", con);
                checkCommand.Parameters.AddWithValue("@Type", newMedType);
                checkCommand.Parameters.AddWithValue("@MedTypesId", Id);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("MedType already exists. Please choose a different MedType.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [MedicationTypes] SET Type = @Type WHERE MedTypesId = @MedTypesId", con);
                updateCommand.Parameters.AddWithValue("@Type", newMedType);
                updateCommand.Parameters.AddWithValue("@MedTypesId", Id);
                updateCommand.ExecuteNonQuery();

                con.Close();
            }

            dgvReset();
            MessageBox.Show("The MedType has been edited successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dgvMedType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMedType.Rows.Count < e.RowIndex - 1)
            {
                DataGridViewRow row = dgvMedType.Rows[e.RowIndex];

                int primaryKey = Convert.ToInt32(row.Cells["MedTypesId"].Value);
                using (SqlConnection connection = new SqlConnection(Program.con))
                {
                    SqlCommand command = new SqlCommand("SELECT MedType FROM [MedicationTypes] WHERE MedTypesId = @MedTypesId", connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@MedTypesId", primaryKey);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string MedType = reader["@Type"].ToString();
                            txtMedType.Text = MedType;
                            connection.Close();
                        }
                    }
                }
            }
        }
    }
}
    
