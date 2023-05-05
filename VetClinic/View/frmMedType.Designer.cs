namespace VetClinic.View
{
    partial class frmMedType
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
            this.txtMedType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMedType = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(230, 424);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(154, 51);
            this.btnRegister.TabIndex = 47;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(49, 339);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 51);
            this.btnBack.TabIndex = 46;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(533, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 51);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(717, 339);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(154, 51);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtMedType
            // 
            this.txtMedType.Location = new System.Drawing.Point(914, 172);
            this.txtMedType.Name = "txtMedType";
            this.txtMedType.Size = new System.Drawing.Size(205, 27);
            this.txtMedType.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(930, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 28);
            this.label1.TabIndex = 42;
            this.label1.Text = "Medication Type";
            // 
            // dgvMedType
            // 
            this.dgvMedType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedType.Location = new System.Drawing.Point(49, 27);
            this.dgvMedType.Name = "dgvMedType";
            this.dgvMedType.RowHeadersWidth = 51;
            this.dgvMedType.RowTemplate.Height = 29;
            this.dgvMedType.Size = new System.Drawing.Size(822, 284);
            this.dgvMedType.TabIndex = 41;
            // 
            // frmMedType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 502);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtMedType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedType);
            this.Name = "frmMedType";
            this.Text = "frmMedType";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegister;
        private Button btnBack;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtMedType;
        private Label label1;
        private DataGridView dgvMedType;
    }
}