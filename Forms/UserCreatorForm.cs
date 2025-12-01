using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bts_gsb.DAO;

namespace bts_gsb.Forms
{
    public partial class UserCreatorForm : Form
    {
        private UserDAO userDAO;

        public UserCreatorForm()
        {
            InitializeComponent();
            userDAO = new UserDAO();
        }

        private void createMedecineButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nameFirstBox.Text))
                {
                    MessageBox.Show("Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(firstnameTextBox.Text))
                {
                    MessageBox.Show("Firstname is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(emailTextBox.Text))
                {
                    MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
                {
                    MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newUser = new User
                {
                    Name = nameFirstBox.Text.Trim(),
                    Firstname = firstnameTextBox.Text.Trim(),
                    Email = emailTextBox.Text.Trim(),
                    Role = adminCheckBox.Checked
                };

                userDAO.Create(newUser, passwordTextBox.Text);

                MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
