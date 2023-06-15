namespace VetClinic.View
{
    partial class frmBreed
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
            txtBreed = new TextBox();
            label1 = new Label();
            dgvBreed = new DataGridView();
            cmbCategory = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBreed).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(217, 423);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(154, 51);
            btnCreate.TabIndex = 40;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(36, 338);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(154, 51);
            btnBack.TabIndex = 39;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(520, 423);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 51);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(704, 338);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(154, 51);
            btnEdit.TabIndex = 37;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // txtBreed
            // 
            txtBreed.Location = new Point(901, 129);
            txtBreed.Name = "txtBreed";
            txtBreed.Size = new Size(205, 27);
            txtBreed.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(968, 88);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 34;
            label1.Text = "Breed";
            // 
            // dgvBreed
            // 
            dgvBreed.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBreed.Location = new Point(36, 26);
            dgvBreed.Name = "dgvBreed";
            dgvBreed.RowHeadersWidth = 51;
            dgvBreed.RowTemplate.Height = 29;
            dgvBreed.Size = new Size(822, 284);
            dgvBreed.TabIndex = 33;
            dgvBreed.CellClick += dgvBreed_CellClick;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(901, 232);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(205, 28);
            cmbCategory.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(952, 185);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 42;
            label2.Text = "Category";
            // 
            // frmBreed
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 526);
            Controls.Add(label2);
            Controls.Add(cmbCategory);
            Controls.Add(btnCreate);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(txtBreed);
            Controls.Add(label1);
            Controls.Add(dgvBreed);
            Name = "frmBreed";
            Text = "frmBreed";
            ((System.ComponentModel.ISupportInitialize)dgvBreed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnBack;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtBreed;
        private Label label1;
        private DataGridView dgvBreed;
        private ComboBox cmbCategory;
        private Label label2;
    }
}