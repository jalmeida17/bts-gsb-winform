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
            SuspendLayout();
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(36, 126);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.PlaceholderText = "Age (ex: 24)";
            ageTextBox.Size = new Size(147, 23);
            ageTextBox.TabIndex = 16;
            // 
            // firstnameTextBox
            // 
            firstnameTextBox.Location = new Point(36, 82);
            firstnameTextBox.Name = "firstnameTextBox";
            firstnameTextBox.PlaceholderText = "Doe";
            firstnameTextBox.Size = new Size(147, 23);
            firstnameTextBox.TabIndex = 15;
            // 
            // nameFirstBox
            // 
            nameFirstBox.Location = new Point(36, 38);
            nameFirstBox.Name = "nameFirstBox";
            nameFirstBox.PlaceholderText = "John";
            nameFirstBox.Size = new Size(147, 23);
            nameFirstBox.TabIndex = 14;
            // 
            // Dosage
            // 
            Dosage.AutoSize = true;
            Dosage.Location = new Point(36, 108);
            Dosage.Name = "Dosage";
            Dosage.Size = new Size(28, 15);
            Dosage.TabIndex = 12;
            Dosage.Text = "Age";
            // 
            // createMedecineButton
            // 
            createMedecineButton.Location = new Point(64, 209);
            createMedecineButton.Name = "createMedecineButton";
            createMedecineButton.Size = new Size(84, 23);
            createMedecineButton.TabIndex = 11;
            createMedecineButton.Text = "Create";
            createMedecineButton.UseVisualStyleBackColor = true;
            createMedecineButton.Click += createPatientButton_Click;
            // 
            // Molecule
            // 
            Molecule.AutoSize = true;
            Molecule.Location = new Point(36, 64);
            Molecule.Name = "Molecule";
            Molecule.Size = new Size(59, 15);
            Molecule.TabIndex = 10;
            Molecule.Text = "Firstname";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(36, 20);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 9;
            NameLabel.Text = "Name";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(36, 152);
            Description.Name = "Description";
            Description.Size = new Size(45, 15);
            Description.TabIndex = 13;
            Description.Text = "Gender";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(36, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(147, 23);
            comboBox1.TabIndex = 18;
            // 
            // PatientCreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 265);
            Controls.Add(comboBox1);
            Controls.Add(ageTextBox);
            Controls.Add(firstnameTextBox);
            Controls.Add(nameFirstBox);
            Controls.Add(Description);
            Controls.Add(Dosage);
            Controls.Add(createMedecineButton);
            Controls.Add(Molecule);
            Controls.Add(NameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PatientCreatorForm";
            Text = "- Patient Creator";
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
    }
}