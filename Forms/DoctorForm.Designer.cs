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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            exportPDFButton = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctorListMedicine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)medicineDAOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPrescription).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPatient).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.FromArgb(231, 76, 60);
            logOutButton.FlatAppearance.BorderSize = 0;
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            logOutButton.ForeColor = Color.White;
            logOutButton.Location = new Point(893, 748);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(110, 40);
            logOutButton.TabIndex = 0;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_click;
            // 
            // dataGridViewDoctorListMedicine
            // 
            dataGridViewDoctorListMedicine.AllowUserToAddRows = false;
            dataGridViewDoctorListMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDoctorListMedicine.BackgroundColor = Color.White;
            dataGridViewDoctorListMedicine.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewDoctorListMedicine.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewDoctorListMedicine.ColumnHeadersHeight = 40;
            dataGridViewDoctorListMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewDoctorListMedicine.EnableHeadersVisualStyles = false;
            dataGridViewDoctorListMedicine.GridColor = Color.FromArgb(236, 240, 241);
            dataGridViewDoctorListMedicine.Location = new Point(15, 50);
            dataGridViewDoctorListMedicine.Name = "dataGridViewDoctorListMedicine";
            dataGridViewDoctorListMedicine.RowHeadersVisible = false;
            dataGridViewDoctorListMedicine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDoctorListMedicine.Size = new Size(580, 240);
            dataGridViewDoctorListMedicine.TabIndex = 1;
            // 
            // medicineDAOBindingSource
            // 
            medicineDAOBindingSource.DataSource = typeof(DAO.MedicineDAO);
            // 
            // createMedecineButton
            // 
            createMedecineButton.BackColor = Color.FromArgb(46, 204, 113);
            createMedecineButton.FlatAppearance.BorderSize = 0;
            createMedecineButton.FlatStyle = FlatStyle.Flat;
            createMedecineButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            createMedecineButton.ForeColor = Color.White;
            createMedecineButton.Location = new Point(15, 300);
            createMedecineButton.Name = "createMedecineButton";
            createMedecineButton.Size = new Size(140, 38);
            createMedecineButton.TabIndex = 2;
            createMedecineButton.Text = "+ Add Medicine";
            createMedecineButton.UseVisualStyleBackColor = false;
            createMedecineButton.Click += createMedecineButton_Click;
            // 
            // createPrescriptionButton
            // 
            createPrescriptionButton.BackColor = Color.FromArgb(52, 152, 219);
            createPrescriptionButton.FlatAppearance.BorderSize = 0;
            createPrescriptionButton.FlatStyle = FlatStyle.Flat;
            createPrescriptionButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            createPrescriptionButton.ForeColor = Color.White;
            createPrescriptionButton.Location = new Point(15, 666);
            createPrescriptionButton.Name = "createPrescriptionButton";
            createPrescriptionButton.Size = new Size(160, 38);
            createPrescriptionButton.TabIndex = 3;
            createPrescriptionButton.Text = "+ New Prescription";
            createPrescriptionButton.UseVisualStyleBackColor = false;
            createPrescriptionButton.Click += createPrescriptionButton_Click;
            // 
            // deleteSelectedButton
            // 
            deleteSelectedButton.BackColor = Color.FromArgb(231, 76, 60);
            deleteSelectedButton.FlatAppearance.BorderSize = 0;
            deleteSelectedButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteSelectedButton.ForeColor = Color.White;
            deleteSelectedButton.Location = new Point(165, 300);
            deleteSelectedButton.Name = "deleteSelectedButton";
            deleteSelectedButton.Size = new Size(140, 38);
            deleteSelectedButton.TabIndex = 4;
            deleteSelectedButton.Text = "Delete Medicine";
            deleteSelectedButton.UseVisualStyleBackColor = false;
            deleteSelectedButton.Click += deleteSelectedButton_Click;
            // 
            // dataGridPrescription
            // 
            dataGridPrescription.AllowUserToAddRows = false;
            dataGridPrescription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPrescription.BackgroundColor = Color.White;
            dataGridPrescription.BorderStyle = BorderStyle.Fixed3D;
            dataGridPrescription.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridPrescription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPrescription.ColumnHeadersHeight = 40;
            dataGridPrescription.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridPrescription.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridPrescription.EnableHeadersVisualStyles = false;
            dataGridPrescription.GridColor = Color.FromArgb(236, 240, 241);
            dataGridPrescription.Location = new Point(15, 50);
            dataGridPrescription.Name = "dataGridPrescription";
            dataGridPrescription.RowHeadersVisible = false;
            dataGridPrescription.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPrescription.Size = new Size(330, 600);
            dataGridPrescription.TabIndex = 5;
            // 
            // dataGridPatient
            // 
            dataGridPatient.AllowUserToAddRows = false;
            dataGridPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPatient.BackgroundColor = Color.White;
            dataGridPatient.BorderStyle = BorderStyle.Fixed3D;
            dataGridPatient.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridPatient.ColumnHeadersHeight = 40;
            dataGridPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridPatient.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridPatient.EnableHeadersVisualStyles = false;
            dataGridPatient.GridColor = Color.FromArgb(236, 240, 241);
            dataGridPatient.Location = new Point(15, 50);
            dataGridPatient.Name = "dataGridPatient";
            dataGridPatient.RowHeadersVisible = false;
            dataGridPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPatient.Size = new Size(580, 240);
            dataGridPatient.TabIndex = 6;
            // 
            // createPatientButton
            // 
            createPatientButton.BackColor = Color.FromArgb(46, 204, 113);
            createPatientButton.FlatAppearance.BorderSize = 0;
            createPatientButton.FlatStyle = FlatStyle.Flat;
            createPatientButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            createPatientButton.ForeColor = Color.White;
            createPatientButton.Location = new Point(15, 300);
            createPatientButton.Name = "createPatientButton";
            createPatientButton.Size = new Size(140, 38);
            createPatientButton.TabIndex = 7;
            createPatientButton.Text = "+ Add Patient";
            createPatientButton.UseVisualStyleBackColor = false;
            createPatientButton.Click += createPatientButton_Click;
            // 
            // deletePatientButton
            // 
            deletePatientButton.BackColor = Color.FromArgb(231, 76, 60);
            deletePatientButton.FlatAppearance.BorderSize = 0;
            deletePatientButton.FlatStyle = FlatStyle.Flat;
            deletePatientButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deletePatientButton.ForeColor = Color.White;
            deletePatientButton.Location = new Point(165, 300);
            deletePatientButton.Name = "deletePatientButton";
            deletePatientButton.Size = new Size(140, 38);
            deletePatientButton.TabIndex = 8;
            deletePatientButton.Text = "Delete Patient";
            deletePatientButton.UseVisualStyleBackColor = false;
            deletePatientButton.Click += deletePatientButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            label1.ForeColor = Color.FromArgb(149, 165, 166);
            label1.Location = new Point(15, 707);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 9;
            label1.Text = "(Select a patient to create)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(15, 15);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 10;
            label2.Text = "Prescriptions";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(15, 15);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 11;
            label3.Text = "Medicines";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(15, 15);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 12;
            label4.Text = "Patients";
            // 
            // exportPDFButton
            // 
            exportPDFButton.BackColor = Color.FromArgb(155, 89, 182);
            exportPDFButton.FlatAppearance.BorderSize = 0;
            exportPDFButton.FlatStyle = FlatStyle.Flat;
            exportPDFButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            exportPDFButton.ForeColor = Color.White;
            exportPDFButton.Location = new Point(241, 666);
            exportPDFButton.Name = "exportPDFButton";
            exportPDFButton.Size = new Size(104, 38);
            exportPDFButton.TabIndex = 13;
            exportPDFButton.Text = "Export to PDF";
            exportPDFButton.UseVisualStyleBackColor = false;
            exportPDFButton.Click += exportPDFButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(250, 251, 252);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridPrescription);
            panel1.Controls.Add(createPrescriptionButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(exportPDFButton);
            panel1.Location = new Point(13, 12);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(360, 730);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(250, 251, 252);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dataGridViewDoctorListMedicine);
            panel2.Controls.Add(createMedecineButton);
            panel2.Controls.Add(deleteSelectedButton);
            panel2.Location = new Point(393, 12);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(610, 360);
            panel2.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(250, 251, 252);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dataGridPatient);
            panel3.Controls.Add(createPatientButton);
            panel3.Controls.Add(deletePatientButton);
            panel3.Location = new Point(393, 382);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(610, 360);
            panel3.TabIndex = 16;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1018, 798);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(logOutButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1034, 837);
            MinimumSize = new Size(1034, 837);
            Name = "DoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "- Doctor Interface";
            Load += DoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctorListMedicine).EndInit();
            ((System.ComponentModel.ISupportInitialize)medicineDAOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPrescription).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPatient).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private Button exportPDFButton;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}