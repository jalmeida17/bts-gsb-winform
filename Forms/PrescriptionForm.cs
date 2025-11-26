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

namespace bts_gsb.Forms
{
    public partial class PrescriptionForm : Form
    {
        private Patient _patient;
        private User _user;
        private List<MedicineSelection> _selectedMedicines = new List<MedicineSelection>();

        public PrescriptionForm(Patient patient, User user)
        {
            InitializeComponent();

            _patient = patient;
            _user = user;

            // Load medicines in top grid
            MedicineDAO medicineDAO = new MedicineDAO();
            List<Medicine> medicines = medicineDAO.GetAll();
            dataGridView1.DataSource = medicines;
            dataGridView1.ReadOnly = true;

            if (dataGridView1.Columns["Id_Medicine"] != null)
                dataGridView1.Columns["Id_Medicine"].HeaderText = "ID";

            // Setup bottom grid for selected medicines
            dataGridView3.DataSource = _selectedMedicines;
            dataGridView3.ReadOnly = true;

            // Set form title with patient name
            this.Text = $"Create Prescription for {patient.Firstname} {patient.Name}";

            // Wire up button events
            button1.Click += AddQuantityButton_Click;
            button2.Click += CreatePrescriptionButton_Click;
        }

        private void AddQuantityButton_Click(object sender, EventArgs e)
        {
            // Check if a medicine is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a medicine first.", "No Medicine Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check quantity
            if (string.IsNullOrWhiteSpace(quantityTextBox.Text) || !int.TryParse(quantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity (positive number).", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Medicine selectedMedicine = dataGridView1.SelectedRows[0].DataBoundItem as Medicine;
            if (selectedMedicine == null) return;

            // Check if medicine already in list
            var existing = _selectedMedicines.FirstOrDefault(m => m.MedicineId == selectedMedicine.Id_Medicine);
            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                _selectedMedicines.Add(new MedicineSelection
                {
                    MedicineId = selectedMedicine.Id_Medicine,
                    MedicineName = selectedMedicine.Name,
                    Quantity = quantity
                });
            }

            // Refresh the grid
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = _selectedMedicines;

            // Clear quantity textbox
            quantityTextBox.Clear();
        }

        private void CreatePrescriptionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selectedMedicines.Count == 0)
                {
                    MessageBox.Show("Please add at least one medicine to the prescription.", "No Medicines", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create the prescription
                Prescription prescription = new Prescription(0, _patient.id_patient, _user.Id, DateTime.Now.AddMonths(1));
                PrescriptionDAO prescriptionDAO = new PrescriptionDAO();
                int prescriptionId = prescriptionDAO.Create(prescription, _user.Id);

                // Add all medicines to the prescription
                AppartientDAO appartientDAO = new AppartientDAO();
                foreach (var medicine in _selectedMedicines)
                {
                    appartientDAO.AddMedicineToPrescription(prescriptionId, medicine.MedicineId, medicine.Quantity);
                }

                MessageBox.Show("Prescription created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating prescription: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper class to display selected medicines
        private class MedicineSelection
        {
            public int MedicineId { get; set; }
            public string MedicineName { get; set; }
            public int Quantity { get; set; }
        }
    }
}
