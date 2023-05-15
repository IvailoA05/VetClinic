namespace VetClinic.View
{
    partial class frmAnimals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            btnRegister = new Button();
            btnBack = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            label2 = new Label();
            txtPetname = new TextBox();
            label1 = new Label();
            dgvAnimals = new DataGridView();
            dtpBirthday = new DateTimePicker();
            dtpVaccdate = new DateTimePicker();
            label5 = new Label();
            cmbCategory = new ComboBox();
            cmdBreed = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            comboBox3 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(915, 329);
            label4.Name = "label4";
            label4.Size = new Size(164, 28);
            label4.TabIndex = 29;
            label4.Text = "VactinationDate";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(226, 426);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(154, 51);
            btnRegister.TabIndex = 28;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(45, 341);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(154, 51);
            btnBack.TabIndex = 27;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(529, 426);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 51);
            btnDelete.TabIndex = 26;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(713, 341);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(154, 51);
            btnEdit.TabIndex = 25;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1185, 91);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 22;
            label2.Text = "Birthday";
            // 
            // txtPetname
            // 
            txtPetname.Location = new Point(891, 122);
            txtPetname.Name = "txtPetname";
            txtPetname.Size = new Size(205, 27);
            txtPetname.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(939, 91);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 20;
            label1.Text = "PetName";
            // 
            // dgvAnimals
            // 
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(45, 29);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.RowTemplate.Height = 29;
            dgvAnimals.Size = new Size(822, 284);
            dgvAnimals.TabIndex = 19;
            // 
            // dtpBirthday
            // 
            dtpBirthday.CustomFormat = "d/M/yyyy";
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.Location = new Point(1132, 122);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(205, 27);
            dtpBirthday.TabIndex = 31;
            // 
            // dtpVaccdate
            // 
            dtpVaccdate.CustomFormat = "d/M/yyyy";
            dtpVaccdate.Format = DateTimePickerFormat.Custom;
            dtpVaccdate.Location = new Point(891, 371);
            dtpVaccdate.Name = "dtpVaccdate";
            dtpVaccdate.Size = new Size(205, 27);
            dtpVaccdate.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(939, 163);
            label5.Name = "label5";
            label5.Size = new Size(98, 28);
            label5.TabIndex = 20;
            label5.Text = "Category";
            label5.Click += label5_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(891, 194);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(205, 28);
            cmbCategory.TabIndex = 33;
            // 
            // cmdBreed
            // 
            cmdBreed.FormattingEnabled = true;
            cmdBreed.Location = new Point(1132, 194);
            cmdBreed.Name = "cmdBreed";
            cmdBreed.Size = new Size(205, 28);
            cmdBreed.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1180, 163);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 34;
            label3.Text = "Breed";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1132, 275);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 28);
            comboBox1.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1180, 244);
            label6.Name = "label6";
            label6.Size = new Size(119, 28);
            label6.TabIndex = 38;
            label6.Text = "Medication";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(891, 275);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(205, 28);
            comboBox2.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(915, 244);
            label7.Name = "label7";
            label7.Size = new Size(170, 28);
            label7.TabIndex = 36;
            label7.Text = "Medication Type";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(939, 29);
            label8.Name = "label8";
            label8.Size = new Size(74, 28);
            label8.TabIndex = 20;
            label8.Text = "Owner";
            label8.Click += label5_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(891, 60);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(205, 28);
            comboBox3.TabIndex = 33;
            // 
            // frmAnimals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 614);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(cmdBreed);
            Controls.Add(label3);
            Controls.Add(comboBox3);
            Controls.Add(cmbCategory);
            Controls.Add(dtpVaccdate);
            Controls.Add(dtpBirthday);
            Controls.Add(label4);
            Controls.Add(btnRegister);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txtPetname);
            Controls.Add(label1);
            Controls.Add(dgvAnimals);
            Name = "frmAnimals";
            Text = "frmAnimals";
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhone;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private Button btnRegister;
        private Button btnBack;
        private Button btnDelete;
        private Button btnEdit;
        private CheckBox chBoxIsAdmin;
        private TextBox txtPassword;
        private Label label2;
        private TextBox txtPetname;
        private Label label1;
        private DataGridView dgvAnimals;
        private DateTimePicker dtpBirthday;
        private DateTimePicker dtpVaccdate;
        private Label label5;
        private ComboBox cmbCategory;
        private ComboBox cmdBreed;
        private ComboBox comboBox1;
        private Label label6;
        private ComboBox comboBox2;
        private Label label7;
        private Label label8;
        private ComboBox comboBox3;
    }
}