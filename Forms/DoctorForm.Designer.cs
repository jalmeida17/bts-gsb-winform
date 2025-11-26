namespace bts_gsb.Forms
{
    partial class DoctorForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            logOutButton = new Button();
            dataGridViewDoctorListMedicine = new DataGridView();
            medicineDAOBindingSource = new BindingSource(components);
            createMedecineButton = new Button();
            createPrescriptionButton = new Button();
            deleteSelectedButton = new Button();
            dataGridPrescription = new DataGridView();
            dataGridPatient = new DataGridView();
            createPatientButton = new Button();
            deletePatientButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctorListMedicine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)medicineDAOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPrescription).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPatient).BeginInit();
            SuspendLayout();
            // 
            // logOutButton
            // 
            logOutButton.Location = new Point(790, 482);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(75, 23);
            logOutButton.TabIndex = 0;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_click;
            // 
            // dataGridViewDoctorListMedicine
            // 
            dataGridViewDoctorListMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewDoctorListMedicine.Location = new Point(337, 31);
            dataGridViewDoctorListMedicine.Name = "dataGridViewDoctorListMedicine";
            dataGridViewDoctorListMedicine.Size = new Size(528, 183);
            dataGridViewDoctorListMedicine.TabIndex = 1;
            // 
            // medicineDAOBindingSource
            // 
            medicineDAOBindingSource.DataSource = typeof(DAO.MedicineDAO);
            // 
            // createMedecineButton
            // 
            createMedecineButton.Location = new Point(337, 220);
            createMedecineButton.Name = "createMedecineButton";
            createMedecineButton.Size = new Size(109, 23);
            createMedecineButton.TabIndex = 2;
            createMedecineButton.Text = "Create Medicine";
            createMedecineButton.UseVisualStyleBackColor = true;
            createMedecineButton.Click += createMedecineButton_Click;
            // 
            // createPrescriptionButton
            // 
            createPrescriptionButton.Location = new Point(97, 454);
            createPrescriptionButton.Name = "createPrescriptionButton";
            createPrescriptionButton.Size = new Size(116, 23);
            createPrescriptionButton.TabIndex = 3;
            createPrescriptionButton.Text = "Create Prescription";
            createPrescriptionButton.UseVisualStyleBackColor = true;
            createPrescriptionButton.Click += createPrescriptionButton_Click;
            // 
            // deleteSelectedButton
            // 
            deleteSelectedButton.Location = new Point(452, 220);
            deleteSelectedButton.Name = "deleteSelectedButton";
            deleteSelectedButton.Size = new Size(99, 23);
            deleteSelectedButton.TabIndex = 4;
            deleteSelectedButton.Text = "Delete Selected";
            deleteSelectedButton.UseVisualStyleBackColor = true;
            deleteSelectedButton.Click += deleteSelectedButton_Click;
            // 
            // dataGridPrescription
            // 
            dataGridPrescription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPrescription.Location = new Point(12, 31);
            dataGridPrescription.Name = "dataGridPrescription";
            dataGridPrescription.Size = new Size(299, 417);
            dataGridPrescription.TabIndex = 5;
            // 
            // dataGridPatient
            // 
            dataGridPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPatient.Location = new Point(337, 276);
            dataGridPatient.Name = "dataGridPatient";
            dataGridPatient.Size = new Size(528, 172);
            dataGridPatient.TabIndex = 6;
            // 
            // createPatientButton
            // 
            createPatientButton.Location = new Point(337, 454);
            createPatientButton.Name = "createPatientButton";
            createPatientButton.Size = new Size(109, 23);
            createPatientButton.TabIndex = 7;
            createPatientButton.Text = "Create Patient";
            createPatientButton.UseVisualStyleBackColor = true;
            createPatientButton.Click += createPatientButton_Click;
            // 
            // deletePatientButton
            // 
            deletePatientButton.Location = new Point(452, 454);
            deletePatientButton.Name = "deletePatientButton";
            deletePatientButton.Size = new Size(99, 23);
            deletePatientButton.TabIndex = 8;
            deletePatientButton.Text = "Delete Patient";
            deletePatientButton.UseVisualStyleBackColor = true;
            deletePatientButton.Click += deletePatientButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 480);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 9;
            label1.Text = "(A patient must be selected)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 10;
            label2.Text = "Prescriptions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 13);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 11;
            label3.Text = "Medecines";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 258);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 12;
            label4.Text = "Patients";
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 517);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(deletePatientButton);
            Controls.Add(createPatientButton);
            Controls.Add(dataGridPatient);
            Controls.Add(dataGridPrescription);
            Controls.Add(deleteSelectedButton);
            Controls.Add(createPrescriptionButton);
            Controls.Add(createMedecineButton);
            Controls.Add(dataGridViewDoctorListMedicine);
            Controls.Add(logOutButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DoctorForm";
            Text = "- Doctor Interface";
            Load += DoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctorListMedicine).EndInit();
            ((System.ComponentModel.ISupportInitialize)medicineDAOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPrescription).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logOutButton;
        private DataGridView dataGridViewDoctorListMedicine;
        private BindingSource medicineDAOBindingSource;
        private Button createMedecineButton;
        private Button createPrescriptionButton;
        private Button deleteSelectedButton;
        private DataGridView dataGridPrescription;
        private DataGridView dataGridPatient;
        private Button createPatientButton;
        private Button deletePatientButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}