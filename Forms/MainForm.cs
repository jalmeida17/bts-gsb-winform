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
            SHA256 sha256 = SHA256.Create();
            byte[] hashValue = sha256.ComputeHash(Encoding.UTF8.GetBytes(this.textBoxLoginPassword.Text));
            string hashString = BitConverter.ToString(hashValue).Replace("-", "").ToLowerInvariant();
            string email = this.textBoxLoginMail.Text;

            UserDAO userDAO = new UserDAO();

            User loggedInUser = userDAO.Login(email, hashString);

            if (loggedInUser != null && loggedInUser.Role == true)
            {
                this.Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
            }
            else if (loggedInUser != null && loggedInUser.Role != true)
            {
                this.Hide();
                DoctorForm doctorForm = new DoctorForm();
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
