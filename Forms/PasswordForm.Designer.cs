namespace bts_gsb.Forms
{
    partial class PasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            goBackButton = new Button();
            updatePasswordButton = new Button();
            emailTextBox = new TextBox();
            oldPasswordTextBox = new TextBox();
            newPasswordTextBox = new TextBox();
            newPasswordLabel = new Label();
            emailLabel = new Label();
            oldPasswordLabel = new Label();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // goBackButton
            // 
            goBackButton.FlatAppearance.BorderColor = Color.FromArgb(149, 165, 166);
            goBackButton.FlatStyle = FlatStyle.Flat;
            goBackButton.Font = new Font("Segoe UI", 9.5F);
            goBackButton.ForeColor = Color.FromArgb(127, 140, 141);
            goBackButton.Location = new Point(60, 450);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(320, 40);
            goBackButton.TabIndex = 0;
            goBackButton.Text = "Back to Login";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // updatePasswordButton
            // 
            updatePasswordButton.BackColor = Color.FromArgb(41, 128, 185);
            updatePasswordButton.FlatAppearance.BorderSize = 0;
            updatePasswordButton.FlatStyle = FlatStyle.Flat;
            updatePasswordButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            updatePasswordButton.ForeColor = Color.White;
            updatePasswordButton.Location = new Point(60, 390);
            updatePasswordButton.Name = "updatePasswordButton";
            updatePasswordButton.Size = new Size(320, 45);
            updatePasswordButton.TabIndex = 1;
            updatePasswordButton.Text = "Update Password";
            updatePasswordButton.UseVisualStyleBackColor = false;
            updatePasswordButton.Click += updatePasswordButton_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.FromArgb(245, 247, 250);
            emailTextBox.Font = new Font("Segoe UI", 11F);
            emailTextBox.Location = new Point(60, 140);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "email@example.com";
            emailTextBox.Size = new Size(320, 27);
            emailTextBox.TabIndex = 2;
            // 
            // oldPasswordTextBox
            // 
            oldPasswordTextBox.BackColor = Color.FromArgb(245, 247, 250);
            oldPasswordTextBox.Font = new Font("Segoe UI", 11F);
            oldPasswordTextBox.Location = new Point(60, 220);
            oldPasswordTextBox.Name = "oldPasswordTextBox";
            oldPasswordTextBox.PlaceholderText = "Enter current password";
            oldPasswordTextBox.Size = new Size(320, 27);
            oldPasswordTextBox.TabIndex = 3;
            oldPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.BackColor = Color.FromArgb(245, 247, 250);
            newPasswordTextBox.Font = new Font("Segoe UI", 11F);
            newPasswordTextBox.Location = new Point(60, 300);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PlaceholderText = "Enter new password";
            newPasswordTextBox.Size = new Size(320, 27);
            newPasswordTextBox.TabIndex = 4;
            newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            newPasswordLabel.ForeColor = Color.FromArgb(52, 73, 94);
            newPasswordLabel.Location = new Point(60, 275);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(97, 17);
            newPasswordLabel.TabIndex = 5;
            newPasswordLabel.Text = "New Password";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            emailLabel.ForeColor = Color.FromArgb(52, 73, 94);
            emailLabel.Location = new Point(60, 115);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(93, 17);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email Address";
            // 
            // oldPasswordLabel
            // 
            oldPasswordLabel.AutoSize = true;
            oldPasswordLabel.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            oldPasswordLabel.ForeColor = Color.FromArgb(52, 73, 94);
            oldPasswordLabel.Location = new Point(60, 195);
            oldPasswordLabel.Name = "oldPasswordLabel";
            oldPasswordLabel.Size = new Size(116, 17);
            oldPasswordLabel.TabIndex = 7;
            oldPasswordLabel.Text = "Current Password";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(44, 62, 80);
            titleLabel.Location = new Point(95, 40);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(226, 30);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "Reset Your Password";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(440, 520);
            Controls.Add(titleLabel);
            Controls.Add(oldPasswordLabel);
            Controls.Add(emailLabel);
            Controls.Add(newPasswordLabel);
            Controls.Add(newPasswordTextBox);
            Controls.Add(oldPasswordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(updatePasswordButton);
            Controls.Add(goBackButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(456, 559);
            MinimumSize = new Size(456, 559);
            Name = "PasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "- Reset Password";
            Load += PasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button goBackButton;
        private Button updatePasswordButton;
        private TextBox emailTextBox;
        private TextBox oldPasswordTextBox;
        private TextBox newPasswordTextBox;
        private Label newPasswordLabel;
        private Label emailLabel;
        private Label oldPasswordLabel;
        private Label titleLabel;
    }
}