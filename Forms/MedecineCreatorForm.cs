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
    public partial class MedecineCreatorForm : Form
    {
        private User _currentUser;

        public MedecineCreatorForm(User user)
        {
            InitializeComponent();
            _currentUser = user ?? throw new ArgumentNullException(nameof(user));
        }

        private void createMedecineButton_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please enter a medicine name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(moleculeTextBox.Text))
            {
                MessageBox.Show("Please enter the active molecule.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                moleculeTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(dosageTextBox.Text))
            {
                MessageBox.Show("Please enter the dosage information.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dosageTextBox.Focus();
                return;
            }

            try
            {
                string name = nameTextBox.Text.Trim();
                string description = descriptionTextBox.Text.Trim();
                string molecule = moleculeTextBox.Text.Trim();
                string dosage = dosageTextBox.Text.Trim();

                // Create a new Medicine object
                Medicine medicine = new Medicine(0, name, molecule, dosage, description);

                MedicineDAO medicineDAO = new MedicineDAO();
                medicineDAO.Create(medicine, _currentUser.Id);

                MessageBox.Show("Medicine created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                // Clear the form for next entry
                ClearForm();
                
                // Close the form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating medicine: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            nameTextBox.Clear();
            moleculeTextBox.Clear();
            dosageTextBox.Clear();
            descriptionTextBox.Clear();
            nameTextBox.Focus();
        }

        private void MedecineCreatorForm_Load(object sender, EventArgs e)
        {
            // Set focus to the name field when form loads
            nameTextBox.Focus();
            
            // Set up Enter key handling for text boxes
            SetupEnterKeyHandling();
        }

        private void SetupEnterKeyHandling()
        {
            nameTextBox.KeyDown += TextBox_KeyDown;
            moleculeTextBox.KeyDown += TextBox_KeyDown;
            dosageTextBox.KeyDown += TextBox_KeyDown;
            descriptionTextBox.KeyDown += TextBox_KeyDown;
        }

        private void TextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Prevent the beep sound
                
                // Move to next control in tab order or trigger create if on last field
                if (sender == nameTextBox)
                    moleculeTextBox.Focus();
                else if (sender == moleculeTextBox)
                    dosageTextBox.Focus();
                else if (sender == dosageTextBox)
                    descriptionTextBox.Focus();
                else if (sender == descriptionTextBox)
                    createMedecineButton.PerformClick();
            }
        }
    }
}
