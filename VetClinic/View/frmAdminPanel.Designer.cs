namespace VetClinic.View
{
    partial class frmAdminPanel
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
            this.dgvVetClinic = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVetClinic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVetClinic
            // 
            this.dgvVetClinic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVetClinic.Location = new System.Drawing.Point(24, 22);
            this.dgvVetClinic.Name = "dgvVetClinic";
            this.dgvVetClinic.RowHeadersWidth = 51;
            this.dgvVetClinic.RowTemplate.Height = 29;
            this.dgvVetClinic.Size = new System.Drawing.Size(390, 284);
            this.dgvVetClinic.TabIndex = 0;
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVetClinic);
            this.Name = "frmAdminPanel";
            this.Text = "frmAdminPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVetClinic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvVetClinic;
    }
}