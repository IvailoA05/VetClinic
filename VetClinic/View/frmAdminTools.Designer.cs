namespace VetClinic.View
{
    partial class frmAdminTools
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnAnimals = new System.Windows.Forms.Button();
            this.btnBreed = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnMedications = new System.Windows.Forms.Button();
            this.btnMedType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(316, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 51);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(180, 19);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(440, 59);
            this.lblLogin.TabIndex = 15;
            this.lblLogin.Text = "Select a table to edit";
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(87, 120);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(154, 51);
            this.btnUsers.TabIndex = 16;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            // 
            // btnAnimals
            // 
            this.btnAnimals.Location = new System.Drawing.Point(87, 199);
            this.btnAnimals.Name = "btnAnimals";
            this.btnAnimals.Size = new System.Drawing.Size(154, 51);
            this.btnAnimals.TabIndex = 17;
            this.btnAnimals.Text = "Animals";
            this.btnAnimals.UseVisualStyleBackColor = true;
            // 
            // btnBreed
            // 
            this.btnBreed.Location = new System.Drawing.Point(87, 287);
            this.btnBreed.Name = "btnBreed";
            this.btnBreed.Size = new System.Drawing.Size(154, 51);
            this.btnBreed.TabIndex = 18;
            this.btnBreed.Text = "Breed";
            this.btnBreed.UseVisualStyleBackColor = true;
            this.btnBreed.Click += new System.EventHandler(this.btnBreed_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(534, 120);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(154, 51);
            this.btnCategory.TabIndex = 19;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnMedications
            // 
            this.btnMedications.Location = new System.Drawing.Point(534, 199);
            this.btnMedications.Name = "btnMedications";
            this.btnMedications.Size = new System.Drawing.Size(154, 51);
            this.btnMedications.TabIndex = 20;
            this.btnMedications.Text = "Medications";
            this.btnMedications.UseVisualStyleBackColor = true;
            this.btnMedications.Click += new System.EventHandler(this.btnMedications_Click);
            // 
            // btnMedType
            // 
            this.btnMedType.Location = new System.Drawing.Point(534, 287);
            this.btnMedType.Name = "btnMedType";
            this.btnMedType.Size = new System.Drawing.Size(154, 51);
            this.btnMedType.TabIndex = 21;
            this.btnMedType.Text = "Medication Type";
            this.btnMedType.UseVisualStyleBackColor = true;
            this.btnMedType.Click += new System.EventHandler(this.btnMedType_Click);
            // 
            // frmAdminTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMedType);
            this.Controls.Add(this.btnMedications);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnBreed);
            this.Controls.Add(this.btnAnimals);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnBack);
            this.Name = "frmAdminTools";
            this.Text = "frmAdminTools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private Label lblLogin;
        private Button btnUsers;
        private Button btnAnimals;
        private Button btnBreed;
        private Button btnCategory;
        private Button btnMedications;
        private Button btnMedType;
    }
}