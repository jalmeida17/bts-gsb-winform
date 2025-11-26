using bts_gsb.DAO;
using bts_gsb.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Text;

namespace bts_gsb
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string password = this.textBoxLoginPassword.Text;
            string email = this.textBoxLoginMail.Text;

            UserDAO userDAO = new UserDAO();

            User loggedInUser = userDAO.Login(email, password);

            if (loggedInUser != null && loggedInUser.Role == true)
            {
                this.Hide();
                AdminForm adminForm = new AdminForm(loggedInUser);
                adminForm.Show();
            }
            else if (loggedInUser != null && loggedInUser.Role != true)
            {
                this.Hide();
                DoctorForm doctorForm = new DoctorForm(loggedInUser);
                doctorForm.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Email and/or Password");
            }
        }
        private void passwordResetButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordForm passwordForm = new PasswordForm();
            passwordForm.Show();

        }

        private void textBoxLoginMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLoginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void githubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://github.com/jalmeida17/bts-gsb-winform";

            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                ((System.Windows.Forms.LinkLabel)sender).LinkVisited = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening link: {ex.Message}");
            }
        }

 
    }
}
