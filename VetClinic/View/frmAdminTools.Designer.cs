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
            btnBack = new Button();
            lblLogin = new Label();
            btnUsers = new Button();
            btnAnimals = new Button();
            btnBreed = new Button();
            btnCategory = new Button();
            btnMedications = new Button();
            btnMedType = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(316, 387);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(154, 51);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogin.Location = new Point(180, 19);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(440, 59);
            lblLogin.TabIndex = 15;
            lblLogin.Text = "Select a table to edit";
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(87, 120);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(154, 51);
            btnUsers.TabIndex = 16;
            btnUsers.Text = "Users";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnAnimals
            // 
            btnAnimals.Location = new Point(87, 199);
            btnAnimals.Name = "btnAnimals";
            btnAnimals.Size = new Size(154, 51);
            btnAnimals.TabIndex = 17;
            btnAnimals.Text = "Animals";
            btnAnimals.UseVisualStyleBackColor = true;
            btnAnimals.Click += btnAnimals_Click;
            // 
            // btnBreed
            // 
            btnBreed.Location = new Point(87, 287);
            btnBreed.Name = "btnBreed";
            btnBreed.Size = new Size(154, 51);
            btnBreed.TabIndex = 18;
            btnBreed.Text = "Breed";
            btnBreed.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(534, 120);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(154, 51);
            btnCategory.TabIndex = 19;
            btnCategory.Text = "Category";
            btnCategory.UseVisualStyleBackColor = true;
            // 
            // btnMedications
            // 
            btnMedications.Location = new Point(534, 199);
            btnMedications.Name = "btnMedications";
            btnMedications.Size = new Size(154, 51);
            btnMedications.TabIndex = 20;
            btnMedications.Text = "Medications";
            btnMedications.UseVisualStyleBackColor = true;
            // 
            // btnMedType
            // 
            btnMedType.Location = new Point(534, 287);
            btnMedType.Name = "btnMedType";
            btnMedType.Size = new Size(154, 51);
            btnMedType.TabIndex = 21;
            btnMedType.Text = "Medication Type";
            btnMedType.UseVisualStyleBackColor = true;
            // 
            // frmAdminTools
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMedType);
            Controls.Add(btnMedications);
            Controls.Add(btnCategory);
            Controls.Add(btnBreed);
            Controls.Add(btnAnimals);
            Controls.Add(btnUsers);
            Controls.Add(lblLogin);
            Controls.Add(btnBack);
            Name = "frmAdminTools";
            Text = "frmAdminTools";
            ResumeLayout(false);
            PerformLayout();
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