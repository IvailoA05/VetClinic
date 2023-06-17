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
using static VetClinic.View.frmBreed;
using static VetClinic.View.frmMedications;

namespace VetClinic.View
{
    public partial class frmMedications : Form
    {
        public frmMedications()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.con))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT MedicationId, MedicationName, ReinsertionDate, Type FROM Medications INNER JOIN MedicationTypes ON Medications.IdType = MedicationTypes.MedTypesId", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvMedications.DataSource = dt;

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                string sql = "SELECT MedTypesId, Type FROM [MedicationTypes]";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int MedicationTypesId = reader.GetInt32(0);
                            string Type = reader.GetString(1);

                            cmbMedType.Items.Add(new ComboBoxMedication(Type, MedicationTypesId));
                        }
                    }
                }
            }
        }

        private void dgvReset()
        {
            this.Hide();
            frmMedications frmMedications = new frmMedications();
            frmMedications.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMedications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Id = (int)dgvMedications.SelectedRows[0].Cells["MedicationId"].Value;

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand command = new SqlCommand("DELETE FROM [Medications] WHERE MedicationId = @MedicationId", con);
                command.Parameters.AddWithValue("@MedicationId", Id);

                command.ExecuteNonQuery();

                dgvReset();
                MessageBox.Show("The medication has been deleted successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMedications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgvMedications.SelectedRows[0];

            int Id = (int)row.Cells["MedicationId"].Value;

            string newMedication = txtMedName.Text.Trim();
            DateTime newReinsertionDate = dtpReinsertion.Value;

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [Medications] WHERE MedicationName = @MedicationName AND ReinsertionDate = @ReinsertionDate AND MedicationId <> @MedicationId", con);
                checkCommand.Parameters.AddWithValue("@MedicationName", newMedication);
                checkCommand.Parameters.AddWithValue("@ReinsertionDate", newReinsertionDate);
                checkCommand.Parameters.AddWithValue("@MedicationId", Id);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Medication already exists. Please choose a different medication.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                ComboBoxMedication selectedMedType = (ComboBoxMedication)cmbMedType.SelectedItem;
                int MedTypeID = selectedMedType.IdType;
                con.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [Medications] SET MedicationName = @MedicationName, ReinsertionDate = @ReinsertionDate, IdType = @IdType WHERE MedicationId = @MedicationId", con);
                updateCommand.Parameters.AddWithValue("@MedicationName", newMedication);
                updateCommand.Parameters.AddWithValue("@ReinsertionDate", newReinsertionDate);
                updateCommand.Parameters.AddWithValue("@MedicationId", Id);
                updateCommand.Parameters.AddWithValue("@IdType", MedTypeID);
                updateCommand.ExecuteNonQuery();

                con.Close();
            }

            dgvReset();
            MessageBox.Show("The Medication has been edited successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            Hide();
            main.Show();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string Medication = txtMedName.Text;

            ComboBoxMedication selectedMedType = (ComboBoxMedication)cmbMedType.SelectedItem;
            int MedTypeID = selectedMedType.IdType;
            DateTime ReinsertionDate = dtpReinsertion.Value;

            if (string.IsNullOrEmpty(Medication))
            {
                MessageBox.Show("Please enter medication name");
                return;
            }

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                string selectSql = "SELECT COUNT(*) FROM [Medications] WHERE MedicationName = @MedicationName";
                string insertSql = "INSERT INTO [Medications] (MedicationName, IdType, ReinsertionDate) VALUES (@MedicationName, @IdType, @ReinsertionDate)";

                using (SqlCommand selectCommand = new SqlCommand(selectSql, con))
                using (SqlCommand insertCommand = new SqlCommand(insertSql, con))
                {
                    selectCommand.Parameters.AddWithValue("@MedicationName", Medication);
                    try
                    {
                        con.Open();
                        int count = (int)selectCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show($"Medication {Medication} already exists. Please choose a different medication.");
                        }
                        else
                        {
                            insertCommand.Parameters.AddWithValue("@MedicationName", Medication);
                            insertCommand.Parameters.AddWithValue("@IdType", MedTypeID);
                            insertCommand.Parameters.AddWithValue("@ReinsertionDate", ReinsertionDate);
                            int result = insertCommand.ExecuteNonQuery();
                            if (result > 0)
                            {
                                dgvReset();
                                MessageBox.Show("The Medication has been created successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Creation failed. Please try again.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while creating the medication. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void dgvMedications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvMedications.Rows.Count - 1)
            {
                txtMedName.Text = "";
                cmbMedType.SelectedIndex = 0;
                dtpReinsertion.Value = new DateTime(2023, 6, 17);
            }
            else
            {
                DataGridViewRow row = dgvMedications.Rows[e.RowIndex];
                int primaryKey = Convert.ToInt32(row.Cells["MedicationId"].Value);
                using (SqlConnection connection = new SqlConnection(Program.con))
                {
                    SqlCommand command = new SqlCommand("SELECT MedicationName, IdType, ReinsertionDate FROM [Medications] WHERE MedicationId = @MedicationId", connection);
                    connection.Open();
                    command.Parameters.AddWithValue("@MedicationId", primaryKey);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string MedicationName = reader["MedicationName"].ToString();
                            string MedTypeID = reader["IdType"].ToString();

                            txtMedName.Text = MedicationName;
                            connection.Close();

                            for (int i = 0; i < cmbMedType.Items.Count; i++)
                            {
                                ComboBoxMedication selectedMedType = (ComboBoxMedication)cmbMedType.Items[i];
                                if (MedTypeID == selectedMedType.IdType.ToString())
                                {
                                    cmbMedType.SelectedIndex = i;
                                    break;
                                }

                            }
                        }
                    }
                }
            }
        }
        public class ComboBoxMedication
        {
            public int IdType { get; set; }
            public string Medication { get; set; }

            public ComboBoxMedication(string medication, int idtype)
            {
                Medication = medication;
                IdType = idtype;
            }

            public override string ToString()
            {
                return Medication;
            }
        }
    }
}
