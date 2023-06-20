﻿using System;
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

        private void cmbPet_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Program.con))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Animals INNER JOIN [User] ON Animals.OwnerId = [User].Id INNER JOIN Breed ON Animals.IDBreed = Breed.BreedId INNER JOIN Medications ON Animals.Vaccines = Medications.MedicationId INNER JOIN Category ON Animals.CategoryId = Category.CategoryId INNER JOIN MedicationTypes ON Animals.MedTypeId = MedicationTypes.MedTypesId", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        sda.Fill(dt);
                    }
                }
            }
            dgvPet.DataSource = dt;

            using (SqlConnection con = new SqlConnection(Program.con))
            {
                con.Open();

                string sql = "SELECT AnimalId, PetName FROM [Animals]";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int AnimalId = reader.GetInt32(0);
                            string PetName = reader.GetString(1);

                            cmbPet.Items.Add(new ComboBoxPet(PetName, AnimalId));
                        }
                    }
                }
            }
        }
        public class ComboBoxPet
        {
            public int AnimalId { get; set; }
            public string PetName { get; set; }

            public ComboBoxPet(string petname, int animalid)
            {
                PetName = petname;
                AnimalId = animalid;
            }

            public override string ToString()
            {
                return PetName;
            }
        }
    }
}
