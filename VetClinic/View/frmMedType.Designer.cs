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
            btnCreate = new Button();
            btnBack = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            txtMedType = new TextBox();
            label1 = new Label();
            dgvMedType = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMedType).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(201, 318);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(135, 38);
            btnCreate.TabIndex = 47;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(43, 254);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(135, 38);
            btnBack.TabIndex = 46;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(466, 318);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 38);
            btnDelete.TabIndex = 45;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(627, 254);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(135, 38);
            btnEdit.TabIndex = 44;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtMedType
            // 
            txtMedType.Location = new Point(800, 129);
            txtMedType.Margin = new Padding(3, 2, 3, 2);
            txtMedType.Name = "txtMedType";
            txtMedType.Size = new Size(180, 23);
            txtMedType.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(814, 96);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 42;
            label1.Text = "Medication Type";
            // 
            // dgvMedType
            // 
            dgvMedType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedType.Location = new Point(43, 20);
            dgvMedType.Margin = new Padding(3, 2, 3, 2);
            dgvMedType.Name = "dgvMedType";
            dgvMedType.RowHeadersWidth = 51;
            dgvMedType.RowTemplate.Height = 29;
            dgvMedType.Size = new Size(719, 213);
            dgvMedType.TabIndex = 41;
            dgvMedType.CellClick += dgvMedType_CellClick;
            // 
            // frmMedType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 376);
            Controls.Add(btnCreate);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(txtMedType);
            Controls.Add(label1);
            Controls.Add(dgvMedType);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmMedType";
            Text = "frmMedType";
            ((System.ComponentModel.ISupportInitialize)dgvMedType).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnBack;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtMedType;
        private Label label1;
        private DataGridView dgvMedType;
    }
}