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
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();

        }

        private void updatePasswordButton_Click(object sender, EventArgs e)
        {
            string email = this.emailTextBox.Text;
            string oldPassword = this.oldPasswordTextBox.Text;
            string newPassword = this.newPasswordTextBox.Text;

            try
            {
                UserDAO userDAO = new UserDAO();
                userDAO.UpdatePassword(email, oldPassword, newPassword);
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                MessageBox.Show("Password updated successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
