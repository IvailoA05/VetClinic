namespace VetClinic.View
{
    partial class frmMedications
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMedications = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpReinsertion = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(206, 424);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(154, 51);
            this.btnRegister.TabIndex = 54;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(25, 339);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 51);
            this.btnBack.TabIndex = 53;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(509, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 51);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(693, 339);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 51);
            this.btnEdit.TabIndex = 51;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtMedName
            // 
            this.txtMedName.Location = new System.Drawing.Point(878, 78);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Size = new System.Drawing.Size(205, 27);
            this.txtMedName.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(891, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 49;
            this.label1.Text = "Medication Name";
            // 
            // dgvMedications
            // 
            this.dgvMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedications.Location = new System.Drawing.Point(25, 27);
            this.dgvMedications.Name = "dgvMedications";
            this.dgvMedications.RowHeadersWidth = 51;
            this.dgvMedications.RowTemplate.Height = 29;
            this.dgvMedications.Size = new System.Drawing.Size(822, 284);
            this.dgvMedications.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(891, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 28);
            this.label2.TabIndex = 55;
            this.label2.Text = "Reinsertion Date";
            // 
            // dtpReinsertion
            // 
            this.dtpReinsertion.CustomFormat = "d/M/yyyy";
            this.dtpReinsertion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReinsertion.Location = new System.Drawing.Point(878, 206);
            this.dtpReinsertion.Name = "dtpReinsertion";
            this.dtpReinsertion.Size = new System.Drawing.Size(205, 27);
            this.dtpReinsertion.TabIndex = 56;
            // 
            // frmMedications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 502);
            this.Controls.Add(this.dtpReinsertion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtMedName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedications);
            this.Name = "frmMedications";
            this.Text = "frmMedications";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegister;
        private Button btnBack;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtMedName;
        private Label label1;
        private DataGridView dgvMedications;
        private Label label2;
        private DateTimePicker dtpReinsertion;
    }
}