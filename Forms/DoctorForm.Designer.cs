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
            logOutButton = new Button();
            dataGridViewDoctorListMedicine = new DataGridView();
            medicineDAOBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctorListMedicine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)medicineDAOBindingSource).BeginInit();
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
            // dataGridViewDoctorListMedicine
            // 
            dataGridViewDoctorListMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoctorListMedicine.Location = new Point(12, 12);
            dataGridViewDoctorListMedicine.Name = "dataGridViewDoctorListMedicine";
            dataGridViewDoctorListMedicine.Size = new Size(776, 397);
            dataGridViewDoctorListMedicine.TabIndex = 1;
            // 
            // medicineDAOBindingSource
            // 
            medicineDAOBindingSource.DataSource = typeof(DAO.MedicineDAO);
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewDoctorListMedicine);
            Controls.Add(logOutButton);
            Name = "DoctorForm";
            Text = "Doctor Interface";
            Load += DoctorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoctorListMedicine).EndInit();
            ((System.ComponentModel.ISupportInitialize)medicineDAOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button logOutButton;
        private DataGridView dataGridViewDoctorListMedicine;
        private BindingSource medicineDAOBindingSource;
    }
}