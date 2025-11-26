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
            SuspendLayout();
            // 
            // goBackButton
            // 
            goBackButton.Location = new Point(73, 227);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(75, 23);
            goBackButton.TabIndex = 0;
            goBackButton.Text = "Go Back";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // updatePasswordButton
            // 
            updatePasswordButton.Location = new Point(55, 198);
            updatePasswordButton.Name = "updatePasswordButton";
            updatePasswordButton.Size = new Size(114, 23);
            updatePasswordButton.TabIndex = 1;
            updatePasswordButton.Text = "Update Password";
            updatePasswordButton.UseVisualStyleBackColor = true;
            updatePasswordButton.Click += updatePasswordButton_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(33, 39);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PlaceholderText = "email@example.com";
            emailTextBox.Size = new Size(155, 23);
            emailTextBox.TabIndex = 2;
            // 
            // oldPasswordTextBox
            // 
            oldPasswordTextBox.Location = new Point(33, 88);
            oldPasswordTextBox.Name = "oldPasswordTextBox";
            oldPasswordTextBox.PlaceholderText = "Password";
            oldPasswordTextBox.Size = new Size(155, 23);
            oldPasswordTextBox.TabIndex = 3;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(33, 157);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PlaceholderText = "Password";
            newPasswordTextBox.Size = new Size(155, 23);
            newPasswordTextBox.TabIndex = 4;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Location = new Point(33, 139);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(84, 15);
            newPasswordLabel.TabIndex = 5;
            newPasswordLabel.Text = "New Password";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(33, 21);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(41, 15);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "E-mail";
            // 
            // oldPasswordLabel
            // 
            oldPasswordLabel.AutoSize = true;
            oldPasswordLabel.Location = new Point(34, 70);
            oldPasswordLabel.Name = "oldPasswordLabel";
            oldPasswordLabel.Size = new Size(79, 15);
            oldPasswordLabel.TabIndex = 7;
            oldPasswordLabel.Text = "Old Password";
            // 
            // PasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 272);
            Controls.Add(oldPasswordLabel);
            Controls.Add(emailLabel);
            Controls.Add(newPasswordLabel);
            Controls.Add(newPasswordTextBox);
            Controls.Add(oldPasswordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(updatePasswordButton);
            Controls.Add(goBackButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PasswordForm";
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
    }
}