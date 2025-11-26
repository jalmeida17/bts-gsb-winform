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
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(35, 18);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(39, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // Molecule
            // 
            Molecule.AutoSize = true;
            Molecule.Location = new Point(35, 62);
            Molecule.Name = "Molecule";
            Molecule.Size = new Size(56, 15);
            Molecule.TabIndex = 1;
            Molecule.Text = "Molecule";
            // 
            // createMedecineButton
            // 
            createMedecineButton.Location = new Point(59, 209);
            createMedecineButton.Name = "createMedecineButton";
            createMedecineButton.Size = new Size(123, 23);
            createMedecineButton.TabIndex = 2;
            createMedecineButton.Text = "Create";
            createMedecineButton.UseVisualStyleBackColor = true;
            createMedecineButton.Click += createMedecineButton_Click;
            // 
            // Dosage
            // 
            Dosage.AutoSize = true;
            Dosage.Location = new Point(35, 106);
            Dosage.Name = "Dosage";
            Dosage.Size = new Size(46, 15);
            Dosage.TabIndex = 3;
            Dosage.Text = "Dosage";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(35, 150);
            Description.Name = "Description";
            Description.Size = new Size(67, 15);
            Description.TabIndex = 4;
            Description.Text = "Description";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(35, 36);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(172, 23);
            nameTextBox.TabIndex = 5;
            // 
            // moleculeTextBox
            // 
            moleculeTextBox.Location = new Point(35, 80);
            moleculeTextBox.Name = "moleculeTextBox";
            moleculeTextBox.Size = new Size(172, 23);
            moleculeTextBox.TabIndex = 6;
            // 
            // dosageTextBox
            // 
            dosageTextBox.Location = new Point(35, 124);
            dosageTextBox.Name = "dosageTextBox";
            dosageTextBox.Size = new Size(172, 23);
            dosageTextBox.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(35, 168);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(172, 23);
            descriptionTextBox.TabIndex = 8;
            // 
            // MedecineCreatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 254);
            Controls.Add(descriptionTextBox);
            Controls.Add(dosageTextBox);
            Controls.Add(moleculeTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(Description);
            Controls.Add(Dosage);
            Controls.Add(createMedecineButton);
            Controls.Add(Molecule);
            Controls.Add(NameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MedecineCreatorForm";
            Text = "- Medecine Creator";
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
    }
}