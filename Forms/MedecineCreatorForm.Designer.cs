namespace bts_gsb.Forms
{
    partial class MedecineCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedecineCreatorForm));
            NameLabel = new Label();
            Molecule = new Label();
            createMedecineButton = new Button();
            Dosage = new Label();
            Description = new Label();
            nameTextBox = new TextBox();
            moleculeTextBox = new TextBox();
            dosageTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            NameLabel.ForeColor = Color.FromArgb(52, 73, 94);
            NameLabel.Location = new Point(50, 55);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(102, 17);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Medicine Name";
            // 
            // Molecule
            // 
            Molecule.AutoSize = true;
            Molecule.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Molecule.ForeColor = Color.FromArgb(52, 73, 94);
            Molecule.Location = new Point(50, 125);
            Molecule.Name = "Molecule";
            Molecule.Size = new Size(62, 17);
            Molecule.TabIndex = 1;
            Molecule.Text = "Molecule";
            // 
            // createMedecineButton
            // 
            createMedecineButton.BackColor = Color.FromArgb(46, 204, 113);
            createMedecineButton.FlatAppearance.BorderSize = 0;
            createMedecineButton.FlatStyle = FlatStyle.Flat;
            createMedecineButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            createMedecineButton.ForeColor = Color.White;
            createMedecineButton.Location = new Point(50, 420);
            createMedecineButton.Name = "createMedecineButton";
            createMedecineButton.Size = new Size(300, 45);
            createMedecineButton.TabIndex = 2;
            createMedecineButton.Text = "Create Medicine";
            createMedecineButton.UseVisualStyleBackColor = false;
            createMedecineButton.Click += createMedecineButton_Click;
            // 
            // Dosage
            // 
            Dosage.AutoSize = true;
            Dosage.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Dosage.ForeColor = Color.FromArgb(52, 73, 94);
            Dosage.Location = new Point(50, 195);
            Dosage.Name = "Dosage";
            Dosage.Size = new Size(53, 17);
            Dosage.TabIndex = 3;
            Dosage.Text = "Dosage";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Description.ForeColor = Color.FromArgb(52, 73, 94);
            Description.Location = new Point(50, 265);
            Description.Name = "Description";
            Description.Size = new Size(76, 17);
            Description.TabIndex = 4;
            Description.Text = "Description";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.FromArgb(245, 247, 250);
            nameTextBox.Font = new Font("Segoe UI", 11F);
            nameTextBox.Location = new Point(50, 80);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Aspirin";
            nameTextBox.Size = new Size(300, 27);
            nameTextBox.TabIndex = 5;
            // 
            // moleculeTextBox
            // 
            moleculeTextBox.BackColor = Color.FromArgb(245, 247, 250);
            moleculeTextBox.Font = new Font("Segoe UI", 11F);
            moleculeTextBox.Location = new Point(50, 150);
            moleculeTextBox.Name = "moleculeTextBox";
            moleculeTextBox.PlaceholderText = "Acetylsalicylic acid";
            moleculeTextBox.Size = new Size(300, 27);
            moleculeTextBox.TabIndex = 6;
            // 
            // dosageTextBox
            // 
            dosageTextBox.BackColor = Color.FromArgb(245, 247, 250);
            dosageTextBox.Font = new Font("Segoe UI", 11F);
            dosageTextBox.Location = new Point(50, 220);
            dosageTextBox.Name = "dosageTextBox";
            dosageTextBox.PlaceholderText = "500mg";
            dosageTextBox.Size = new Size(300, 27);
            dosageTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = Color.FromArgb(245, 247, 250);
            descriptionTextBox.Font = new Font("Segoe UI", 11F);
            descriptionTextBox.Location = new Point(50, 290);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.PlaceholderText = "Pain reliever and fever reducer";
            descriptionTextBox.Size = new Size(300, 100);
            descriptionTextBox.TabIndex = 8;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(44, 62, 80);
            titleLabel.Location = new Point(85, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(200, 25);
            titleLabel.TabIndex = 9;
            titleLabel.Text = "Create New Medicine";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MedecineCreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 500);
            Controls.Add(titleLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(dosageTextBox);
            Controls.Add(moleculeTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(Description);
            Controls.Add(Dosage);
            Controls.Add(createMedecineButton);
            Controls.Add(Molecule);
            Controls.Add(NameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(416, 539);
            MinimumSize = new Size(416, 539);
            Name = "MedecineCreatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "- Create Medicine";
            Load += MedecineCreatorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label Molecule;
        private Button createMedecineButton;
        private Label Dosage;
        private Label Description;
        private TextBox nameTextBox;
        private TextBox moleculeTextBox;
        private TextBox dosageTextBox;
        private TextBox descriptionTextBox;
        private Label titleLabel;
    }
}