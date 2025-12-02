namespace bts_gsb.Forms
{
    partial class PatientCreatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientCreatorForm));
            ageTextBox = new TextBox();
            firstnameTextBox = new TextBox();
            nameFirstBox = new TextBox();
            Dosage = new Label();
            createMedecineButton = new Button();
            Molecule = new Label();
            NameLabel = new Label();
            Description = new Label();
            comboBox1 = new ComboBox();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // ageTextBox
            // 
            ageTextBox.BackColor = Color.FromArgb(245, 247, 250);
            ageTextBox.Font = new Font("Segoe UI", 11F);
            ageTextBox.Location = new Point(50, 220);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.PlaceholderText = "24";
            ageTextBox.Size = new Size(300, 27);
            ageTextBox.TabIndex = 16;
            // 
            // firstnameTextBox
            // 
            firstnameTextBox.BackColor = Color.FromArgb(245, 247, 250);
            firstnameTextBox.Font = new Font("Segoe UI", 11F);
            firstnameTextBox.Location = new Point(50, 150);
            firstnameTextBox.Name = "firstnameTextBox";
            firstnameTextBox.PlaceholderText = "John";
            firstnameTextBox.Size = new Size(300, 27);
            firstnameTextBox.TabIndex = 15;
            // 
            // nameFirstBox
            // 
            nameFirstBox.BackColor = Color.FromArgb(245, 247, 250);
            nameFirstBox.Font = new Font("Segoe UI", 11F);
            nameFirstBox.Location = new Point(50, 80);
            nameFirstBox.Name = "nameFirstBox";
            nameFirstBox.PlaceholderText = "Doe";
            nameFirstBox.Size = new Size(300, 27);
            nameFirstBox.TabIndex = 14;
            // 
            // Dosage
            // 
            Dosage.AutoSize = true;
            Dosage.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Dosage.ForeColor = Color.FromArgb(52, 73, 94);
            Dosage.Location = new Point(50, 195);
            Dosage.Name = "Dosage";
            Dosage.Size = new Size(32, 17);
            Dosage.TabIndex = 12;
            Dosage.Text = "Age";
            // 
            // createMedecineButton
            // 
            createMedecineButton.BackColor = Color.FromArgb(46, 204, 113);
            createMedecineButton.FlatAppearance.BorderSize = 0;
            createMedecineButton.FlatStyle = FlatStyle.Flat;
            createMedecineButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            createMedecineButton.ForeColor = Color.White;
            createMedecineButton.Location = new Point(50, 360);
            createMedecineButton.Name = "createMedecineButton";
            createMedecineButton.Size = new Size(300, 45);
            createMedecineButton.TabIndex = 11;
            createMedecineButton.Text = "Create Patient";
            createMedecineButton.UseVisualStyleBackColor = false;
            createMedecineButton.Click += createPatientButton_Click;
            // 
            // Molecule
            // 
            Molecule.AutoSize = true;
            Molecule.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Molecule.ForeColor = Color.FromArgb(52, 73, 94);
            Molecule.Location = new Point(50, 125);
            Molecule.Name = "Molecule";
            Molecule.Size = new Size(68, 17);
            Molecule.TabIndex = 10;
            Molecule.Text = "Firstname";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            NameLabel.ForeColor = Color.FromArgb(52, 73, 94);
            NameLabel.Location = new Point(50, 55);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(44, 17);
            NameLabel.TabIndex = 9;
            NameLabel.Text = "Name";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            Description.ForeColor = Color.FromArgb(52, 73, 94);
            Description.Location = new Point(50, 265);
            Description.Name = "Description";
            Description.Size = new Size(52, 17);
            Description.TabIndex = 13;
            Description.Text = "Gender";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(245, 247, 250);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = new Font("Segoe UI", 11F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(50, 290);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(300, 28);
            comboBox1.TabIndex = 18;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(44, 62, 80);
            titleLabel.Location = new Point(100, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(182, 25);
            titleLabel.TabIndex = 19;
            titleLabel.Text = "Create New Patient";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PatientCreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 440);
            Controls.Add(titleLabel);
            Controls.Add(comboBox1);
            Controls.Add(ageTextBox);
            Controls.Add(firstnameTextBox);
            Controls.Add(nameFirstBox);
            Controls.Add(Description);
            Controls.Add(Dosage);
            Controls.Add(createMedecineButton);
            Controls.Add(Molecule);
            Controls.Add(NameLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(416, 479);
            MinimumSize = new Size(416, 479);
            Name = "PatientCreatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "- Create Patient";
            Load += PatientCreatorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ageTextBox;
        private TextBox firstnameTextBox;
        private TextBox nameFirstBox;
        private Label Dosage;
        private Button createMedecineButton;
        private Label Molecule;
        private Label NameLabel;
        private Label Description;
        private ComboBox comboBox1;
        private Label titleLabel;
    }
}