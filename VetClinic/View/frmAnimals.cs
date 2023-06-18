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
    public partial class frmAnimals : Form
    {
        public frmAnimals()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.con))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT AnimalId, PetName, Birthday, Category, Breed, Username, Type, MedicationName, VaccinationDate FROM Animals INNER JOIN User ON Animals.OwnerId = User.Id INNER JOIN Breed ON Animals.IDBreed = Breed.BreedId INNER JOIN Medications ON Animals.Vaccines = Medications.MedicationId INNER JOIN Category ON Animals.CategoryId = Category.CategoryId INNER JOIN MedicationTypes ON Animals.MedTypeId = MedicationTypes.MedTypesId", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvAnimals.DataSource = dt;

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                string sql = "SELECT MedicationId, MedicationName FROM [Medications]";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int MedicationId = reader.GetInt32(0);
                            string MedicationName = reader.GetString(1);

                            cmbMedType.Items.Add(new ComboBoxMedication(MedicationName, MedicationId));
                        }
                    }
                }
            }
            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                string sql = "SELECT CategoryId, Category FROM [Category]";

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
            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                string sql = "SELECT Id, Username FROM [User]";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int Id = reader.GetInt32(0);
                            string Username = reader.GetString(1);

                            cmbOwner.Items.Add(new ComboBoxUser(Username, Id));
                        }
                    }
                }
            }
            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                string sql = "SELECT BreedId, Breed FROM [Breed]";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int BreedId = reader.GetInt32(0);
                            string Breed = reader.GetString(1);

                            cmbBreed.Items.Add(new ComboBoxBreed(Breed, BreedId));
                        }
                    }
                }
            }
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

                            cmbMedType.Items.Add(new ComboBoxMedType(Type, MedicationTypesId));
                        }
                    }
                }
            }
        }
        private void dgvReset()
        {
            this.Hide();
            frmAnimals frmAnimals = new frmAnimals();
            frmAnimals.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int Id = (int)dgvAnimals.SelectedRows[0].Cells["AnimalId"].Value;

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand command = new SqlCommand("DELETE FROM [Animals] WHERE AnimalId = @AnimalId", con);
                command.Parameters.AddWithValue("@AnimalId", Id);

                command.ExecuteNonQuery();

                dgvReset();
                MessageBox.Show("The animal has been deleted successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgvAnimals.SelectedRows[0];

            int Id = (int)row.Cells["AnimalId"].Value;

            string newAnimal = txtPetname.Text.Trim();
            DateTime newVaccinationDate = dtpVaccdate.Value;
            DateTime newBirthday = dtpBirthday.Value;

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM [Animals] WHERE PetName = @PetName AND VaccinationDate = @VaccinationDate AND Birthday = @Birthday AND AnimalId <> @AnimalId", con);
                checkCommand.Parameters.AddWithValue("@PetName", newAnimal);
                checkCommand.Parameters.AddWithValue("@VaccinationDate", newVaccinationDate);
                checkCommand.Parameters.AddWithValue("@Birthday", newBirthday);
                checkCommand.Parameters.AddWithValue("@AnimalId", Id);
                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Animal already exists. Please choose a different animal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                ComboBoxMedType selectedMedType = (ComboBoxMedType)cmbMedType.SelectedItem;
                int MedTypeID = selectedMedType.MedTypeId;
                con.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [Animals] SET PetName = @PetName, VaccinationDate = @VaccinationDate, MedTypeId = @MedTypeId WHERE AnimalId = @AnimalId", con);
                updateCommand.Parameters.AddWithValue("@PetName", newAnimal);
                updateCommand.Parameters.AddWithValue("@VaccinationDate", newVaccinationDate);
                updateCommand.Parameters.AddWithValue("@AnimalId", Id);
                updateCommand.Parameters.AddWithValue("@MedTypeId", MedTypeID);
                updateCommand.ExecuteNonQuery();

                con.Close();
            }
            using (SqlConnection con = new SqlConnection(Program.con))
            {
                ComboBoxMedication selectedMedication = (ComboBoxMedication)cmbMedication.SelectedItem;
                int MedicationID = selectedMedication.Vaccines;
                con.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [Animals] SET PetName = @PetName, VaccinationDate = @VaccinationDate, Vaccines = @Vaccines WHERE AnimalId = @AnimalId", con);
                updateCommand.Parameters.AddWithValue("@PetName", newAnimal);
                updateCommand.Parameters.AddWithValue("@VaccinationDate", newVaccinationDate);
                updateCommand.Parameters.AddWithValue("@AnimalId", Id);
                updateCommand.Parameters.AddWithValue("@Vaccines", MedicationID);
                updateCommand.ExecuteNonQuery();

                con.Close();
            }
            using (SqlConnection con = new SqlConnection(Program.con))
            {
                ComboBoxBreed selectedBreed = (ComboBoxBreed)cmbBreed.SelectedItem;
                int IDBreed = selectedBreed.IdBreed;
                con.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [Animals] SET PetName = @PetName, VaccinationDate = @VaccinationDate, IdBreed = @IdBreed WHERE AnimalId = @AnimalId", con);
                updateCommand.Parameters.AddWithValue("@PetName", newAnimal);
                updateCommand.Parameters.AddWithValue("@VaccinationDate", newVaccinationDate);
                updateCommand.Parameters.AddWithValue("@AnimalId", Id);
                updateCommand.Parameters.AddWithValue("@IdBreed", IDBreed);
                updateCommand.ExecuteNonQuery();

                con.Close();
            }
            using (SqlConnection con = new SqlConnection(Program.con))
            {
                ComboBoxCategory selectedCategory = (ComboBoxCategory)cmbCategory.SelectedItem;
                int CategoryID = selectedCategory.CategoryId;
                con.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [Animals] SET PetName = @PetName, VaccinationDate = @VaccinationDate, CategoryId = @CategoryId WHERE AnimalId = @AnimalId", con);
                updateCommand.Parameters.AddWithValue("@PetName", newAnimal);
                updateCommand.Parameters.AddWithValue("@VaccinationDate", newVaccinationDate);
                updateCommand.Parameters.AddWithValue("@AnimalId", Id);
                updateCommand.Parameters.AddWithValue("@CateogryId", CategoryID);
                updateCommand.ExecuteNonQuery();

                con.Close();
            }
            using (SqlConnection con = new SqlConnection(Program.con))
            {
                ComboBoxUser selectedOwner = (ComboBoxUser)cmbOwner.SelectedItem;
                int OwnerID = selectedOwner.OwnerId;
                con.Open();

                SqlCommand updateCommand = new SqlCommand("UPDATE [Animals] SET PetName = @PetName, VaccinationDate = @VaccinationDate, OwnerId = @OwnerId WHERE AnimalId = @AnimalId", con);
                updateCommand.Parameters.AddWithValue("@PetName", newAnimal);
                updateCommand.Parameters.AddWithValue("@VaccinationDate", newVaccinationDate);
                updateCommand.Parameters.AddWithValue("@AnimalId", Id);
                updateCommand.Parameters.AddWithValue("@OwnerId", OwnerID);
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
    }
}
