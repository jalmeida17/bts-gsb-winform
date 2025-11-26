using bts_gsb.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using iText.Kernel.Colors;

namespace bts_gsb.Forms
{
    public partial class DoctorForm : Form
    {
        private User currentUser;

        public DoctorForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            MedicineDAO medicineDAO = new MedicineDAO();
            List<Medicine> medicines = medicineDAO.GetAll();

            this.dataGridViewDoctorListMedicine.DataSource = medicines;

            // Enable editing and set up event handlers for automatic updates
            this.dataGridViewDoctorListMedicine.AllowUserToAddRows = false;
            this.dataGridViewDoctorListMedicine.AllowUserToDeleteRows = false;
            this.dataGridViewDoctorListMedicine.CellEndEdit += DataGridViewDoctorListMedicine_CellEndEdit;
            this.dataGridViewDoctorListMedicine.DataError += DataGridViewDoctorListMedicine_DataError;
            this.dataGridViewDoctorListMedicine.CellDoubleClick += DataGridViewDoctorListMedicine_CellDoubleClick;

            // Configure column properties after data binding
            ConfigureDataGridViewColumns();

            // Load patients from database
            PatientDAO patientDAO = new PatientDAO();
            List<Patient> patients = patientDAO.GetAll();
            this.dataGridPatient.DataSource = patients;
            this.dataGridPatient.ReadOnly = true;
            this.dataGridPatient.CellFormatting += DataGridPatient_CellFormatting;
            ConfigurePatientGrid();

            // Load prescriptions from database
            PrescriptionDAO prescriptionDAO = new PrescriptionDAO();
            List<Prescription> prescriptions = prescriptionDAO.GetAll();
            this.dataGridPrescription.DataSource = prescriptions;
            this.dataGridPrescription.ReadOnly = true;
            this.dataGridPrescription.CellFormatting += DataGridPrescription_CellFormatting;
            ConfigurePrescriptionGrid();
        }

        private void logOutButton_click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {

        }

        private void createMedecineButton_Click(object sender, EventArgs e)
        {
            MedecineCreatorForm medecineCreatorForm = new MedecineCreatorForm(currentUser);
            medecineCreatorForm.ShowDialog();

            // Refresh the medicine list after creating a new medicine
            RefreshMedicineList();
        }

        private void RefreshMedicineList()
        {
            MedicineDAO medicineDAO = new MedicineDAO();
            List<Medicine> medicines = medicineDAO.GetAll();
            this.dataGridViewDoctorListMedicine.DataSource = medicines;
            ConfigureDataGridViewColumns();
        }

        private void ConfigureDataGridViewColumns()
        {
            if (this.dataGridViewDoctorListMedicine.Columns.Count > 0)
            {
                // Make ID column read-only
                if (this.dataGridViewDoctorListMedicine.Columns["Id_Medicine"] != null)
                {
                    this.dataGridViewDoctorListMedicine.Columns["Id_Medicine"].ReadOnly = true;
                    this.dataGridViewDoctorListMedicine.Columns["Id_Medicine"].HeaderText = "ID";
                }

                // Make User column read-only if it exists
                if (this.dataGridViewDoctorListMedicine.Columns["User"] != null)
                {
                    this.dataGridViewDoctorListMedicine.Columns["User"].ReadOnly = true;
                }

                // Set friendly column headers
                if (this.dataGridViewDoctorListMedicine.Columns["Name"] != null)
                    this.dataGridViewDoctorListMedicine.Columns["Name"].HeaderText = "Medicine Name";

                if (this.dataGridViewDoctorListMedicine.Columns["Molecule"] != null)
                    this.dataGridViewDoctorListMedicine.Columns["Molecule"].HeaderText = "Molecule";

                if (this.dataGridViewDoctorListMedicine.Columns["Dosage"] != null)
                    this.dataGridViewDoctorListMedicine.Columns["Dosage"].HeaderText = "Dosage";

                if (this.dataGridViewDoctorListMedicine.Columns["Description"] != null)
                    this.dataGridViewDoctorListMedicine.Columns["Description"].HeaderText = "Description";

                // Auto-size columns
                this.dataGridViewDoctorListMedicine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void DataGridViewDoctorListMedicine_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView? dgv = sender as DataGridView;
                if (dgv == null) return;

                // Get the edited row
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                // Check if this is a valid medicine row (has an ID)
                if (row.Cells["Id_Medicine"].Value == null) return;

                // Create a Medicine object from the edited row
                Medicine medicine = new Medicine(
                    Convert.ToInt32(row.Cells["Id_Medicine"].Value),
                    row.Cells["Name"].Value?.ToString() ?? "",
                    row.Cells["Molecule"].Value?.ToString() ?? "",
                    row.Cells["Dosage"].Value?.ToString() ?? "",
                    row.Cells["Description"].Value?.ToString() ?? ""
                );

                // Validate the medicine data
                if (string.IsNullOrWhiteSpace(medicine.Name))
                {
                    MessageBox.Show("Medicine name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RefreshMedicineList(); // Revert changes
                    return;
                }

                // Update the medicine in the database
                MedicineDAO medicineDAO = new MedicineDAO();
                medicineDAO.Update(medicine, currentUser.Id);

                MessageBox.Show("Medicine updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh the list to show updated data
                RefreshMedicineList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Refresh the list to revert changes
                RefreshMedicineList();
            }
        }

        private void DataGridViewDoctorListMedicine_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Data error in row {e.RowIndex + 1}, column {e.ColumnIndex + 1}: {e.Exception?.Message ?? "Unknown error"}",
                           "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            e.Cancel = true;
        }

        private void DataGridViewDoctorListMedicine_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ignore header row clicks
                if (e.RowIndex < 0) return;

                // Get the medicine from the clicked row
                DataGridView? dgv = sender as DataGridView;
                if (dgv == null) return;

                Medicine selectedMedicine = dgv.Rows[e.RowIndex].DataBoundItem as Medicine;
                if (selectedMedicine == null) return;

                // Build the message with medicine details
                string medicineInfo = $"Medicine Details:\n\n" +
                                     $"ID: {selectedMedicine.Id_Medicine}\n" +
                                     $"Name: {selectedMedicine.Name}\n" +
                                     $"Molecule: {selectedMedicine.Molecule}\n" +
                                     $"Dosage: {selectedMedicine.Dosage}\n" +
                                     $"Description: {selectedMedicine.Description}";

                // Add user information if available
                if (selectedMedicine.User != null)
                {
                    medicineInfo += $"\n\nCreated by: {selectedMedicine.User.Firstname} {selectedMedicine.User.Name}\n" +
                                   $"Email: {selectedMedicine.User.Email}";
                }

                // Show the message box
                MessageBox.Show(medicineInfo, "Medicine Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying medicine details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any rows are selected
                if (dataGridViewDoctorListMedicine.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select one or more medicines to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Confirm deletion
                string confirmMessage = dataGridViewDoctorListMedicine.SelectedRows.Count == 1
                    ? "Are you sure you want to delete the selected medicine?"
                    : $"Are you sure you want to delete {dataGridViewDoctorListMedicine.SelectedRows.Count} medicines?";

                DialogResult result = MessageBox.Show(confirmMessage, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MedicineDAO medicineDAO = new MedicineDAO();
                    int deletedCount = 0;

                    // Delete all selected rows
                    foreach (DataGridViewRow row in dataGridViewDoctorListMedicine.SelectedRows)
                    {
                        if (row.DataBoundItem is Medicine selectedMedicine)
                        {
                            medicineDAO.Delete(selectedMedicine.Id_Medicine);
                            deletedCount++;
                        }
                    }

                    // Refresh the medicine list to update the interface
                    RefreshMedicineList();

                    string successMessage = deletedCount == 1
                        ? "Medicine deleted successfully!"
                        : $"{deletedCount} medicines deleted successfully!";

                    MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting medicine(s): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createPrescriptionButton_Click(object sender, EventArgs e)
        {
            if (dataGridPatient.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient first.", "No Patient Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridPatient.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one patient.", "Multiple Patients Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Patient selectedPatient = dataGridPatient.SelectedRows[0].DataBoundItem as Patient;
            if (selectedPatient == null)
            {
                MessageBox.Show("Invalid patient selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PrescriptionForm prescriptionForm = new PrescriptionForm(selectedPatient, currentUser);
            prescriptionForm.ShowDialog();

            RefreshPrescriptionList();
        }

        private void RefreshPrescriptionList()
        {
            PrescriptionDAO prescriptionDAO = new PrescriptionDAO();
            List<Prescription> prescriptions = prescriptionDAO.GetAll();
            this.dataGridPrescription.DataSource = prescriptions;
        }

        private void ConfigurePatientGrid()
        {
            if (this.dataGridPatient.Columns["id_patient"] != null)
                this.dataGridPatient.Columns["id_patient"].HeaderText = "ID";

            if (this.dataGridPatient.Columns["id_user"] != null)
                this.dataGridPatient.Columns["id_user"].Visible = false;

            if (this.dataGridPatient.Columns["Prescriptions"] != null)
                this.dataGridPatient.Columns["Prescriptions"].Visible = false;

            if (this.dataGridPatient.Columns["User"] != null)
                this.dataGridPatient.Columns["User"].Visible = false;
        }

        private void ConfigurePrescriptionGrid()
        {
            if (this.dataGridPrescription.Columns["Id_Prescription"] != null)
                this.dataGridPrescription.Columns["Id_Prescription"].HeaderText = "ID";

            if (this.dataGridPrescription.Columns["id_patient"] != null)
                this.dataGridPrescription.Columns["id_patient"].Visible = false;

            if (this.dataGridPrescription.Columns["id_user"] != null)
                this.dataGridPrescription.Columns["id_user"].Visible = false;

            if (this.dataGridPrescription.Columns["User"] != null)
                this.dataGridPrescription.Columns["User"].Visible = false;

            if (this.dataGridPrescription.Columns["Appartients"] != null)
                this.dataGridPrescription.Columns["Appartients"].Visible = false;
        }

        private void DataGridPatient_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridPatient.Columns[e.ColumnIndex].Name == "Gender" && e.Value != null)
            {
                bool genderValue = (bool)e.Value;
                e.Value = genderValue ? "Male" : "Female";
                e.FormattingApplied = true;
            }
        }

        private void DataGridPrescription_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridPrescription.Columns[e.ColumnIndex].Name == "Patient" && e.Value != null)
            {
                if (e.Value is Patient patient)
                {
                    e.Value = patient.Name;
                    e.FormattingApplied = true;
                }
            }
        }

        private void createPatientButton_Click(object sender, EventArgs e)
        {
            PatientCreatorForm patientCreatorForm = new PatientCreatorForm(currentUser);
            patientCreatorForm.ShowDialog();

            RefreshPatientList();
        }

        private void RefreshPatientList()
        {
            PatientDAO patientDAO = new PatientDAO();
            List<Patient> patients = patientDAO.GetAll();
            this.dataGridPatient.DataSource = patients;
        }

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridPatient.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select one or more patients to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string confirmMessage = dataGridPatient.SelectedRows.Count == 1
                    ? "Are you sure you want to delete the selected patient?"
                    : $"Are you sure you want to delete {dataGridPatient.SelectedRows.Count} patients?";

                DialogResult result = MessageBox.Show(confirmMessage, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    PatientDAO patientDAO = new PatientDAO();
                    int deletedCount = 0;

                    foreach (DataGridViewRow row in dataGridPatient.SelectedRows)
                    {
                        if (row.DataBoundItem is Patient selectedPatient)
                        {
                            patientDAO.Delete(selectedPatient.id_patient);
                            deletedCount++;
                        }
                    }

                    RefreshPatientList();

                    string successMessage = deletedCount == 1
                        ? "Patient deleted successfully!"
                        : $"{deletedCount} patients deleted successfully!";

                    MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting patient(s): {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportPDFButton_Click(object sender, EventArgs e)
        {
            StringBuilder log = new StringBuilder();
            log.AppendLine("=== PDF EXPORT LOG ===");

            try
            {
                if (dataGridPrescription.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a prescription to export.", "No Prescription Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                log.AppendLine("✓ Step 1: Selection OK");

                Prescription selectedPrescription = dataGridPrescription.SelectedRows[0].DataBoundItem as Prescription;
                if (selectedPrescription == null)
                {
                    MessageBox.Show("Invalid prescription selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                log.AppendLine($"✓ Step 2: Prescription ID = {selectedPrescription.Id_Prescription}");

                AppartientDAO appartientDAO = new AppartientDAO();
                List<Appartient> medicines = appartientDAO.GetMedicinesForPrescription(selectedPrescription.Id_Prescription);
                log.AppendLine($"✓ Step 3: Medicines loaded = {medicines?.Count ?? 0}");

                // SAVE FILE DIALOG
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Save Prescription";
                dialog.Filter = "PDF (*.pdf)|*.pdf";
                dialog.FileName = $"Prescription_{selectedPrescription.Patient?.Name ?? "Patient"}_{selectedPrescription.Patient?.Firstname ?? ""}_{DateTime.Now:yyyyMMdd_HHmm}.pdf";

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                string filePath = dialog.FileName;
                log.AppendLine($"✓ Step 4: File path = {filePath}");

                DateTime validityDate = selectedPrescription.Validity ?? DateTime.Now;
                log.AppendLine($"✓ Step 5: Validity date = {validityDate}");

                log.AppendLine("→ Step 6: Creating font...");
                PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                log.AppendLine("✓ Step 6: Font created");

                log.AppendLine("→ Step 7: Creating PDF writer...");
                using (PdfWriter writer = new PdfWriter(filePath))
                {
                    log.AppendLine("✓ Step 7: Writer created");
                    log.AppendLine("→ Step 8: Creating PDF document...");
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        log.AppendLine("✓ Step 8: PDF document created");
                        log.AppendLine("→ Step 9: Creating Document...");
                        using (Document doc = new Document(pdf))
                        {
                            log.AppendLine("✓ Step 9: Document created");

                            log.AppendLine("→ Step 10: Adding title...");
                            doc.Add(new Paragraph("MEDICAL PRESCRIPTION")
                                .SetFont(boldFont)
                                .SetFontSize(22)
                                .SetTextAlignment(TextAlignment.CENTER));
                            doc.Add(new Paragraph("\n"));
                            log.AppendLine("✓ Step 10: Title added");

                            log.AppendLine("→ Step 11: Building patient info...");
                            string patientName = (selectedPrescription.Patient?.Name ?? "[Unknown]") + " " + (selectedPrescription.Patient?.Firstname ?? "");
                            string doctorName = (selectedPrescription.User?.Name ?? "[Doctor]") + " " + (selectedPrescription.User?.Firstname ?? "");
                            string patientAge = selectedPrescription.Patient?.Age?.ToString() ?? "N/A";
                            string patientGender = selectedPrescription.Patient?.Gender == true ? "Male" : "Female";

                            doc.Add(new Paragraph($"Patient: {patientName}"));
                            doc.Add(new Paragraph($"Age: {patientAge}"));
                            doc.Add(new Paragraph($"Gender: {patientGender}"));
                            doc.Add(new Paragraph($"Doctor: Dr {doctorName}"));
                            doc.Add(new Paragraph($"Validity: {validityDate:dd/MM/yyyy}"));
                            doc.Add(new Paragraph("\n"));
                            log.AppendLine("✓ Step 11: Patient info added");

                            log.AppendLine("→ Step 12: Creating table...");
                            float[] widths = { 3, 2, 1 };
                            Table table = new Table(UnitValue.CreatePercentArray(widths)).UseAllAvailableWidth();

                            table.AddHeaderCell(new Cell().Add(new Paragraph("Medicine")).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                            table.AddHeaderCell(new Cell().Add(new Paragraph("Dosage")).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                            table.AddHeaderCell(new Cell().Add(new Paragraph("Quantity")).SetBackgroundColor(ColorConstants.LIGHT_GRAY));

                            log.AppendLine("→ Step 13: Adding medicines...");
                            foreach (var medicine in medicines)
                            {
                                if (medicine?.Medicine != null)
                                {
                                    string medNameSafe = medicine.Medicine.Name ?? "[Name missing]";
                                    string dosageSafe = medicine.Medicine.Dosage ?? "N/A";
                                    int qty = medicine.Quantity ?? 0;

                                    table.AddCell(new Cell().Add(new Paragraph(medNameSafe)));
                                    table.AddCell(new Cell().Add(new Paragraph(dosageSafe)));
                                    table.AddCell(new Cell().Add(new Paragraph(qty.ToString())));
                                }
                            }

                            doc.Add(table);
                            log.AppendLine("✓ Step 13: Table added");

                            log.AppendLine("→ Step 14: Adding signature...");
                            doc.Add(new Paragraph("\n\nDoctor's signature:\n\n"));
                            doc.Add(new Paragraph($"Dr. {doctorName}"));
                            doc.Add(new Paragraph($"Email: {selectedPrescription.User?.Email ?? "N/A"}"));
                            log.AppendLine("✓ Step 14: Signature added");

                            log.AppendLine("→ Step 15: Closing document...");
                            doc.Close();
                            log.AppendLine("✓ Step 15: Document closed");
                        }
                    }
                }

                log.AppendLine("→ Step 16: Opening file...");
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = filePath,
                    UseShellExecute = true
                });

                log.AppendLine("✓ SUCCESS!");
                MessageBox.Show($"Prescription exported successfully!", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                log.AppendLine("\n❌ ERROR OCCURRED!");
                log.AppendLine($"Error Type: {ex.GetType().Name}");
                log.AppendLine($"Error Message: {ex.Message}");
                log.AppendLine($"\nStack Trace:\n{ex.StackTrace}");

                if (ex.InnerException != null)
                {
                    log.AppendLine($"\nInner Exception: {ex.InnerException.GetType().Name}");
                    log.AppendLine($"Inner Message: {ex.InnerException.Message}");
                    log.AppendLine($"Inner Stack:\n{ex.InnerException.StackTrace}");
                }

                MessageBox.Show(
                    log.ToString(),
                    "PDF Export Error - Full Log",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
