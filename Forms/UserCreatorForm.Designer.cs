namespace bts_gsb.Forms
{
    partial class UserCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCreatorForm));
            emailTextBox = new TextBox();
            firstnameTextBox = new TextBox();
            nameFirstBox = new TextBox();
            Password = new Label();
            Email = new Label();
            createMedecineButton = new Button();
            Molecule = new Label();
            NameLabel = new Label();
            passwordTextBox = new TextBox();
            adminCheckBox = new CheckBox();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.FromArgb(245, 247, 250);
            emailTextBox.Font = new Font("Segoe UI", 11F);
            emailTextBox.Location = new Point(50, 220);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "johndoe@example.com";
            emailTextBox.Size = new Size(300, 27);
            emailTextBox.TabIndex = 26;
            // 
            // firstnameTextBox
            // 
            firstnameTextBox.BackColor = Color.FromArgb(245, 247, 250);
            firstnameTextBox.Font = new Font("Segoe UI", 11F);
            firstnameTextBox.Location = new Point(50, 150);
            firstnameTextBox.Name = "firstnameTextBox";
            firstnameTextBox.PlaceholderText = "John";
            firstnameTextBox.Size = new Size(300, 27);
            firstnameTextBox.TabIndex = 25;
            // 
            // nameFirstBox
            // 
            nameFirstBox.BackColor = Color.FromArgb(245, 247, 250);
            nameFirstBox.Font = new Font("Segoe UI", 11F);
            nameFirstBox.Location = new Point(50, 80);
            nameFirstBox.Name = "nameFirstBox";
            nameFirstBox.PlaceholderText = "Doe";
            nameFirstBox.Size = new Size(300, 27);
            nameFirstBox.TabIndex = 24;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Password.ForeColor = Color.FromArgb(52, 73, 94);
            Password.Location = new Point(50, 265);
            Password.Name = "Password";
            Password.Size = new Size(66, 17);
            Password.TabIndex = 23;
            Password.Text = "Password";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Email.ForeColor = Color.FromArgb(52, 73, 94);
            Email.Location = new Point(50, 195);
            Email.Name = "Email";
            Email.Size = new Size(93, 17);
            Email.TabIndex = 22;
            Email.Text = "Email Address";
            // 
            // createMedecineButton
            // 
            createMedecineButton.BackColor = Color.FromArgb(46, 204, 113);
            createMedecineButton.FlatAppearance.BorderSize = 0;
            createMedecineButton.FlatStyle = FlatStyle.Flat;
            createMedecineButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            createMedecineButton.ForeColor = Color.White;
            createMedecineButton.Location = new Point(50, 400);
            createMedecineButton.Name = "createMedecineButton";
            createMedecineButton.Size = new Size(300, 45);
            createMedecineButton.TabIndex = 21;
            createMedecineButton.Text = "Create User";
            createMedecineButton.UseVisualStyleBackColor = false;
            createMedecineButton.Click += createMedecineButton_Click;
            // 
            // Molecule
            // 
            Molecule.AutoSize = true;
            Molecule.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Molecule.ForeColor = Color.FromArgb(52, 73, 94);
            Molecule.Location = new Point(50, 125);
            Molecule.Name = "Molecule";
            Molecule.Size = new Size(74, 17);
            Molecule.TabIndex = 20;
            Molecule.Text = "First Name";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            NameLabel.ForeColor = Color.FromArgb(52, 73, 94);
            NameLabel.Location = new Point(50, 55);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(72, 17);
            NameLabel.TabIndex = 19;
            NameLabel.Text = "Last Name";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(245, 247, 250);
            passwordTextBox.Font = new Font("Segoe UI", 11F);
            passwordTextBox.Location = new Point(50, 290);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Strong password";
            passwordTextBox.Size = new Size(300, 27);
            passwordTextBox.TabIndex = 28;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // adminCheckBox
            // 
            adminCheckBox.AutoSize = true;
            adminCheckBox.Font = new Font("Segoe UI", 10F);
            adminCheckBox.ForeColor = Color.FromArgb(52, 73, 94);
            adminCheckBox.Location = new Point(103, 340);
            adminCheckBox.Name = "adminCheckBox";
            adminCheckBox.Size = new Size(166, 23);
            adminCheckBox.TabIndex = 29;
            adminCheckBox.Text = "Grant admin privileges";
            adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(44, 62, 80);
            titleLabel.Location = new Point(110, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(159, 25);
            titleLabel.TabIndex = 30;
            titleLabel.Text = "Create New User";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserCreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 468);
            Controls.Add(titleLabel);
            Controls.Add(adminCheckBox);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(firstnameTextBox);
            Controls.Add(nameFirstBox);
            Controls.Add(Password);
            Controls.Add(Email);
            Controls.Add(createMedecineButton);
            Controls.Add(Molecule);
            Controls.Add(NameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(416, 507);
            MinimumSize = new Size(416, 507);
            Name = "UserCreatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "- Create User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailTextBox;
        private TextBox firstnameTextBox;
        private TextBox nameFirstBox;
        private Label Password;
        private Label Email;
        private Button createMedecineButton;
        private Label Molecule;
        private Label NameLabel;
        private TextBox passwordTextBox;
        private CheckBox adminCheckBox;
        private Label titleLabel;
    }
}