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
            SuspendLayout();
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(29, 119);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "Email (ex: johndoe@test.com)";
            emailTextBox.Size = new Size(147, 23);
            emailTextBox.TabIndex = 26;
            // 
            // firstnameTextBox
            // 
            firstnameTextBox.Location = new Point(29, 75);
            firstnameTextBox.Name = "firstnameTextBox";
            firstnameTextBox.PlaceholderText = "Doe";
            firstnameTextBox.Size = new Size(147, 23);
            firstnameTextBox.TabIndex = 25;
            // 
            // nameFirstBox
            // 
            nameFirstBox.Location = new Point(29, 31);
            nameFirstBox.Name = "nameFirstBox";
            nameFirstBox.PlaceholderText = "John";
            nameFirstBox.Size = new Size(147, 23);
            nameFirstBox.TabIndex = 24;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(29, 145);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 23;
            Password.Text = "Password";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(29, 101);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 22;
            Email.Text = "Email";
            // 
            // createMedecineButton
            // 
            createMedecineButton.Location = new Point(64, 226);
            createMedecineButton.Name = "createMedecineButton";
            createMedecineButton.Size = new Size(84, 23);
            createMedecineButton.TabIndex = 21;
            createMedecineButton.Text = "Create";
            createMedecineButton.UseVisualStyleBackColor = true;
            createMedecineButton.Click += createMedecineButton_Click;
            // 
            // Molecule
            // 
            Molecule.AutoSize = true;
            Molecule.Location = new Point(29, 57);
            Molecule.Name = "Molecule";
            Molecule.Size = new Size(64, 15);
            Molecule.TabIndex = 20;
            Molecule.Text = "First Name";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(29, 13);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 19;
            NameLabel.Text = "Name";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(29, 163);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password (ex : Strongpass123_)";
            passwordTextBox.Size = new Size(147, 23);
            passwordTextBox.TabIndex = 28;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // adminCheckBox
            // 
            adminCheckBox.AutoSize = true;
            adminCheckBox.Location = new Point(64, 192);
            adminCheckBox.Name = "adminCheckBox";
            adminCheckBox.Size = new Size(62, 19);
            adminCheckBox.TabIndex = 29;
            adminCheckBox.Text = "Admin";
            adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // UserCreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(223, 257);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserCreatorForm";
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
    }
}