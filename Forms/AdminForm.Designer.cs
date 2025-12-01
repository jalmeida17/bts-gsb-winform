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
            usersDataGridView = new DataGridView();
            label1 = new Label();
            createUserButton = new Button();
            deleteUserButton = new Button();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
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
            // usersDataGridView
            // 
            usersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            usersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGridView.Location = new Point(12, 24);
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.Size = new Size(776, 385);
            usersDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 2;
            label1.Text = "Users";
            // 
            // createUserButton
            //
            createUserButton.Location = new Point(713, 415);
            createUserButton.Name = "createUserButton";
            createUserButton.Size = new Size(75, 23);
            createUserButton.TabIndex = 3;
            createUserButton.Text = "Create User";
            createUserButton.UseVisualStyleBackColor = true;
            createUserButton.Click += createUserButton_Click;
            // 
            // deleteUserButton
            // 
            deleteUserButton.Location = new Point(580, 415);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(127, 23);
            deleteUserButton.TabIndex = 4;
            deleteUserButton.Text = "Delete Selected User";
            deleteUserButton.UseVisualStyleBackColor = true;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteUserButton);
            Controls.Add(createUserButton);
            Controls.Add(label1);
            Controls.Add(usersDataGridView);
            Controls.Add(logOutButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdminForm";
            Text = "- Admin Interface";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logOutButton;
        private DataGridView usersDataGridView;
        private Label label1;
        private Button createUserButton;
        private Button deleteUserButton;
    }
}