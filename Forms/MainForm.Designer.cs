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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(84, 177);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(79, 23);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxLoginPassword.Location = new Point(41, 134);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.PlaceholderText = "Password";
            textBoxLoginPassword.Size = new Size(167, 23);
            textBoxLoginPassword.TabIndex = 1;
            textBoxLoginPassword.UseSystemPasswordChar = true;
            textBoxLoginPassword.TextChanged += textBoxLoginPassword_TextChanged;
            // 
            // textBoxLoginMail
            // 
            textBoxLoginMail.BorderStyle = BorderStyle.FixedSingle;
            textBoxLoginMail.Location = new Point(41, 84);
            textBoxLoginMail.Name = "textBoxLoginMail";
            textBoxLoginMail.PlaceholderText = "email@example.com";
            textBoxLoginMail.Size = new Size(167, 23);
            textBoxLoginMail.TabIndex = 0;
            textBoxLoginMail.TextChanged += textBoxLoginMail_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(7, 52);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // emailLoginLabel
            // 
            emailLoginLabel.AutoSize = true;
            emailLoginLabel.Location = new Point(41, 66);
            emailLoginLabel.Name = "emailLoginLabel";
            emailLoginLabel.Size = new Size(42, 15);
            emailLoginLabel.TabIndex = 3;
            emailLoginLabel.Text = "Email :";
            // 
            // passwordLoginLabel
            // 
            passwordLoginLabel.AutoSize = true;
            passwordLoginLabel.Location = new Point(41, 116);
            passwordLoginLabel.Name = "passwordLoginLabel";
            passwordLoginLabel.Size = new Size(63, 15);
            passwordLoginLabel.TabIndex = 4;
            passwordLoginLabel.Text = "Password :";
            // 
            // passwordResetButton
            // 
            passwordResetButton.Location = new Point(63, 206);
            passwordResetButton.Name = "passwordResetButton";
            passwordResetButton.Size = new Size(123, 23);
            passwordResetButton.TabIndex = 5;
            passwordResetButton.Text = "Forgot password";
            passwordResetButton.Click += passwordResetButton_Click;
            // 
            // githubLinkLabel
            // 
            githubLinkLabel.AutoSize = true;
            githubLinkLabel.Location = new Point(5, 235);
            githubLinkLabel.Name = "githubLinkLabel";
            githubLinkLabel.Size = new Size(45, 15);
            githubLinkLabel.TabIndex = 6;
            githubLinkLabel.TabStop = true;
            githubLinkLabel.Text = "GitHub";
            githubLinkLabel.LinkClicked += githubLinkLabel_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gsb_light;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(41, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 256);
            Controls.Add(pictureBox1);
            Controls.Add(githubLinkLabel);
            Controls.Add(passwordResetButton);
            Controls.Add(passwordLoginLabel);
            Controls.Add(emailLoginLabel);
            Controls.Add(label1);
            Controls.Add(textBoxLoginMail);
            Controls.Add(textBoxLoginPassword);
            Controls.Add(buttonLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
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
    }
}
