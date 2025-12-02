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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            logOutButton = new Button();
            usersDataGridView = new DataGridView();
            label1 = new Label();
            createUserButton = new Button();
            deleteUserButton = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.FromArgb(231, 76, 60);
            logOutButton.FlatAppearance.BorderSize = 0;
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            logOutButton.ForeColor = Color.White;
            logOutButton.Location = new Point(12, 588);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(110, 40);
            logOutButton.TabIndex = 0;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_click;
            // 
            // usersDataGridView
            // 
            usersDataGridView.AllowUserToAddRows = false;
            usersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            usersDataGridView.BackgroundColor = Color.White;
            usersDataGridView.BorderStyle = BorderStyle.Fixed3D;
            usersDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            usersDataGridView.ColumnHeadersHeight = 40;
            usersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            usersDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            usersDataGridView.EnableHeadersVisualStyles = false;
            usersDataGridView.GridColor = Color.FromArgb(236, 240, 241);
            usersDataGridView.Location = new Point(15, 50);
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.RowHeadersVisible = false;
            usersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersDataGridView.Size = new Size(930, 450);
            usersDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 2;
            label1.Text = "Users";
            // 
            // createUserButton
            // 
            createUserButton.BackColor = Color.FromArgb(46, 204, 113);
            createUserButton.FlatAppearance.BorderSize = 0;
            createUserButton.FlatStyle = FlatStyle.Flat;
            createUserButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            createUserButton.ForeColor = Color.White;
            createUserButton.Location = new Point(820, 515);
            createUserButton.Name = "createUserButton";
            createUserButton.Size = new Size(125, 40);
            createUserButton.TabIndex = 3;
            createUserButton.Text = "+ Create User";
            createUserButton.UseVisualStyleBackColor = false;
            createUserButton.Click += createUserButton_Click;
            // 
            // deleteUserButton
            // 
            deleteUserButton.BackColor = Color.FromArgb(231, 76, 60);
            deleteUserButton.FlatAppearance.BorderSize = 0;
            deleteUserButton.FlatStyle = FlatStyle.Flat;
            deleteUserButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteUserButton.ForeColor = Color.White;
            deleteUserButton.Location = new Point(655, 515);
            deleteUserButton.Name = "deleteUserButton";
            deleteUserButton.Size = new Size(155, 40);
            deleteUserButton.TabIndex = 4;
            deleteUserButton.Text = "Delete Selected";
            deleteUserButton.UseVisualStyleBackColor = false;
            deleteUserButton.Click += deleteUserButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(250, 251, 252);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(usersDataGridView);
            panel1.Controls.Add(createUserButton);
            panel1.Controls.Add(deleteUserButton);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(960, 570);
            panel1.TabIndex = 5;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(981, 643);
            Controls.Add(panel1);
            Controls.Add(logOutButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(997, 682);
            MinimumSize = new Size(997, 682);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "- Admin Interface";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button logOutButton;
        private DataGridView usersDataGridView;
        private Label label1;
        private Button createUserButton;
        private Button deleteUserButton;
        private Panel panel1;
    }
}