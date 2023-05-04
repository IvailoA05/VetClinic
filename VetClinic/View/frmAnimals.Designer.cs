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
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(920, 224);
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
            label2.Location = new Point(949, 119);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 22;
            label2.Text = "Birthday";
            // 
            // txtPetname
            // 
            txtPetname.Location = new Point(896, 47);
            txtPetname.Name = "txtPetname";
            txtPetname.Size = new Size(205, 27);
            txtPetname.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(944, 16);
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
            dtpBirthday.Format = DateTimePickerFormat.Custom;
            dtpBirthday.CustomFormat = "d/M/yyyy" ;
            dtpBirthday.Location = new Point(896, 150);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(205, 27);
            dtpBirthday.TabIndex = 31;
            // 
            // dtpVaccdate
            // 
            dtpVaccdate.Format = DateTimePickerFormat.Custom;
            dtpVaccdate.CustomFormat = "d/M/yyyy";
            dtpVaccdate.Location = new Point(896, 277);
            dtpVaccdate.Name = "dtpVaccdate";
            dtpVaccdate.Size = new Size(205, 27);
            dtpVaccdate.TabIndex = 32;
            // 
            // frmAnimals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 503);
            Controls.Add(dtpVaccdate);
            Controls.Add(dtpBirthday);
            Controls.Add(label4);
            Controls.Add(btnRegister);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(label2);
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
    }
}