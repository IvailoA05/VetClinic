namespace VetClinic.View
{
    partial class frmMain
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
            btnLogOut = new Button();
            btnAdminTools = new Button();
            dgvPet = new DataGridView();
            cmbPet = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPet).BeginInit();
            SuspendLayout();
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(787, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(105, 38);
            btnLogOut.TabIndex = 0;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnAdminTools
            // 
            btnAdminTools.Location = new Point(12, 12);
            btnAdminTools.Name = "btnAdminTools";
            btnAdminTools.Size = new Size(105, 38);
            btnAdminTools.TabIndex = 1;
            btnAdminTools.Text = "Admin Tools";
            btnAdminTools.UseVisualStyleBackColor = true;
            btnAdminTools.Visible = false;
            btnAdminTools.Click += btnAdminTools_Click;
            // 
            // dgvPet
            // 
            dgvPet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPet.Location = new Point(29, 110);
            dgvPet.Name = "dgvPet";
            dgvPet.RowHeadersWidth = 51;
            dgvPet.RowTemplate.Height = 29;
            dgvPet.Size = new Size(850, 371);
            dgvPet.TabIndex = 2;
            // 
            // cmbPet
            // 
            cmbPet.FormattingEnabled = true;
            cmbPet.Location = new Point(352, 66);
            cmbPet.Name = "cmbPet";
            cmbPet.Size = new Size(205, 28);
            cmbPet.TabIndex = 35;
            cmbPet.SelectedIndexChanged += cmbPet_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(429, 22);
            label5.Name = "label5";
            label5.Size = new Size(42, 28);
            label5.TabIndex = 34;
            label5.Text = "Pet";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 522);
            Controls.Add(cmbPet);
            Controls.Add(label5);
            Controls.Add(dgvPet);
            Controls.Add(btnAdminTools);
            Controls.Add(btnLogOut);
            Name = "frmMain";
            Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)dgvPet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogOut;
        private Button btnAdminTools;
        private DataGridView dgvPet;
        private ComboBox cmbPet;
        private Label label5;
    }
}