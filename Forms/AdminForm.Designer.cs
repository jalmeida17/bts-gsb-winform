namespace bts_gsb.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            logOutButton = new Button();
            SuspendLayout();
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(12, 415);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(75, 23);
            logOutButton.TabIndex = 0;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logOutButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            Text = "- Admin Interface";
            Load += AdminForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button logOutButton;
    }
}