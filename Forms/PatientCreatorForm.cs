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
    public partial class PatientCreatorForm : Form
    {
        private User _currentUser;

        public PatientCreatorForm(User user)
        {
            InitializeComponent();
            _currentUser = user ?? throw new ArgumentNullException(nameof(user));
        }

        private void createPatientButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameFirstBox.Text))
            {
                MessageBox.Show("Please enter a patient name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameFirstBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(firstnameTextBox.Text))
            {
                MessageBox.Show("Please enter a patient firstname.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstnameTextBox.Focus();
                return;
            }

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox1.Focus();
                return;
            }

            try
            {
                string name = nameFirstBox.Text.Trim();
                string firstname = firstnameTextBox.Text.Trim();
                int? age = null;

                if (!string.IsNullOrWhiteSpace(ageTextBox.Text))
                {
                    if (int.TryParse(ageTextBox.Text.Trim(), out int parsedAge))
                    {
                        age = parsedAge;
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid age number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ageTextBox.Focus();
                        return;
                    }
                }

                bool gender = comboBox1.SelectedItem.ToString() == "Male";

                Patient patient = new Patient(0, name, firstname, gender, age);

                PatientDAO patientDAO = new PatientDAO();
                patientDAO.Create(patient, _currentUser.Id);

                MessageBox.Show("Patient created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PatientCreatorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
