namespace bts_gsb
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogin = new Button();
            textBoxLoginPassword = new TextBox();
            textBoxLoginMail = new TextBox();
            label1 = new Label();
            emailLoginLabel = new Label();
            passwordLoginLabel = new Label();
            passwordResetButton = new Button();
            githubLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(79, 121);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(79, 23);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxLoginPassword.Location = new Point(34, 82);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.PlaceholderText = "password";
            textBoxLoginPassword.Size = new Size(167, 23);
            textBoxLoginPassword.TabIndex = 1;
            textBoxLoginPassword.UseSystemPasswordChar = true;
            textBoxLoginPassword.TextChanged += textBoxLoginPassword_TextChanged;
            // 
            // textBoxLoginMail
            // 
            textBoxLoginMail.BorderStyle = BorderStyle.FixedSingle;
            textBoxLoginMail.Location = new Point(34, 32);
            textBoxLoginMail.Name = "textBoxLoginMail";
            textBoxLoginMail.PlaceholderText = "email@example.com";
            textBoxLoginMail.Size = new Size(167, 23);
            textBoxLoginMail.TabIndex = 0;
            textBoxLoginMail.TextChanged += textBoxLoginMail_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // emailLoginLabel
            // 
            emailLoginLabel.AutoSize = true;
            emailLoginLabel.Location = new Point(34, 14);
            emailLoginLabel.Name = "emailLoginLabel";
            emailLoginLabel.Size = new Size(42, 15);
            emailLoginLabel.TabIndex = 3;
            emailLoginLabel.Text = "Email :";
            // 
            // passwordLoginLabel
            // 
            passwordLoginLabel.AutoSize = true;
            passwordLoginLabel.Location = new Point(34, 64);
            passwordLoginLabel.Name = "passwordLoginLabel";
            passwordLoginLabel.Size = new Size(63, 15);
            passwordLoginLabel.TabIndex = 4;
            passwordLoginLabel.Text = "Password :";
            // 
            // passwordResetButton
            // 
            passwordResetButton.Location = new Point(58, 150);
            passwordResetButton.Name = "passwordResetButton";
            passwordResetButton.Size = new Size(123, 23);
            passwordResetButton.TabIndex = 5;
            passwordResetButton.Text = "Forgot password";
            passwordResetButton.Click += passwordResetButton_Click;
            // 
            // githubLinkLabel
            // 
            githubLinkLabel.AutoSize = true;
            githubLinkLabel.Location = new Point(95, 176);
            githubLinkLabel.Name = "githubLinkLabel";
            githubLinkLabel.Size = new Size(45, 15);
            githubLinkLabel.TabIndex = 6;
            githubLinkLabel.TabStop = true;
            githubLinkLabel.Text = "GitHub";
            githubLinkLabel.LinkClicked += githubLinkLabel_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 202);
            Controls.Add(githubLinkLabel);
            Controls.Add(passwordResetButton);
            Controls.Add(passwordLoginLabel);
            Controls.Add(emailLoginLabel);
            Controls.Add(label1);
            Controls.Add(textBoxLoginMail);
            Controls.Add(textBoxLoginPassword);
            Controls.Add(buttonLogin);
            Name = "MainForm";
            Text = "Login";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private TextBox textBoxLoginPassword;
        private TextBox textBoxLoginMail;
        private Label label1;
        private Label emailLoginLabel;
        private Label passwordLoginLabel;
        private Button passwordResetButton;
        private LinkLabel githubLinkLabel;
    }
}
