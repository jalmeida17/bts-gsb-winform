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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            buttonLogin = new Button();
            textBoxLoginPassword = new TextBox();
            textBoxLoginMail = new TextBox();
            label1 = new Label();
            emailLoginLabel = new Label();
            passwordLoginLabel = new Label();
            passwordResetButton = new Button();
            githubLinkLabel = new LinkLabel();
            pictureBox1 = new PictureBox();
            titleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(41, 128, 185);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(80, 340);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(280, 45);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Sign In";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.BackColor = Color.FromArgb(245, 247, 250);
            textBoxLoginPassword.Font = new Font("Segoe UI", 11F);
            textBoxLoginPassword.Location = new Point(80, 270);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.PlaceholderText = "Enter your password";
            textBoxLoginPassword.Size = new Size(280, 27);
            textBoxLoginPassword.TabIndex = 1;
            textBoxLoginPassword.UseSystemPasswordChar = true;
            textBoxLoginPassword.TextChanged += textBoxLoginPassword_TextChanged;
            // 
            // textBoxLoginMail
            // 
            textBoxLoginMail.BackColor = Color.FromArgb(245, 247, 250);
            textBoxLoginMail.Font = new Font("Segoe UI", 11F);
            textBoxLoginMail.Location = new Point(80, 190);
            textBoxLoginMail.Name = "textBoxLoginMail";
            textBoxLoginMail.PlaceholderText = "email@example.com";
            textBoxLoginMail.Size = new Size(280, 27);
            textBoxLoginMail.TabIndex = 0;
            textBoxLoginMail.TextChanged += textBoxLoginMail_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(7, 52);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Visible = false;
            // 
            // emailLoginLabel
            // 
            emailLoginLabel.AutoSize = true;
            emailLoginLabel.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            emailLoginLabel.ForeColor = Color.FromArgb(52, 73, 94);
            emailLoginLabel.Location = new Point(80, 165);
            emailLoginLabel.Name = "emailLoginLabel";
            emailLoginLabel.Size = new Size(40, 17);
            emailLoginLabel.TabIndex = 3;
            emailLoginLabel.Text = "Email";
            // 
            // passwordLoginLabel
            // 
            passwordLoginLabel.AutoSize = true;
            passwordLoginLabel.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            passwordLoginLabel.ForeColor = Color.FromArgb(52, 73, 94);
            passwordLoginLabel.Location = new Point(80, 245);
            passwordLoginLabel.Name = "passwordLoginLabel";
            passwordLoginLabel.Size = new Size(66, 17);
            passwordLoginLabel.TabIndex = 4;
            passwordLoginLabel.Text = "Password";
            // 
            // passwordResetButton
            // 
            passwordResetButton.FlatAppearance.BorderSize = 0;
            passwordResetButton.FlatStyle = FlatStyle.Flat;
            passwordResetButton.Font = new Font("Segoe UI", 9F);
            passwordResetButton.ForeColor = Color.FromArgb(41, 128, 185);
            passwordResetButton.Location = new Point(80, 395);
            passwordResetButton.Name = "passwordResetButton";
            passwordResetButton.Size = new Size(280, 28);
            passwordResetButton.TabIndex = 5;
            passwordResetButton.Text = "Forgot password?";
            passwordResetButton.UseVisualStyleBackColor = true;
            passwordResetButton.Click += passwordResetButton_Click;
            // 
            // githubLinkLabel
            // 
            githubLinkLabel.AutoSize = true;
            githubLinkLabel.Font = new Font("Segoe UI", 8.5F);
            githubLinkLabel.LinkColor = Color.FromArgb(149, 165, 166);
            githubLinkLabel.Location = new Point(175, 443);
            githubLinkLabel.Name = "githubLinkLabel";
            githubLinkLabel.Size = new Size(90, 15);
            githubLinkLabel.TabIndex = 6;
            githubLinkLabel.TabStop = true;
            githubLinkLabel.Text = "View on GitHub";
            githubLinkLabel.LinkClicked += githubLinkLabel_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gsb_light;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(130, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(44, 62, 80);
            titleLabel.Location = new Point(154, 103);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(140, 25);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "Welcome Back";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(440, 467);
            Controls.Add(titleLabel);
            Controls.Add(pictureBox1);
            Controls.Add(githubLinkLabel);
            Controls.Add(passwordResetButton);
            Controls.Add(passwordLoginLabel);
            Controls.Add(emailLoginLabel);
            Controls.Add(label1);
            Controls.Add(textBoxLoginMail);
            Controls.Add(textBoxLoginPassword);
            Controls.Add(buttonLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(456, 506);
            MinimumSize = new Size(456, 506);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "- Login";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label titleLabel;
    }
}
