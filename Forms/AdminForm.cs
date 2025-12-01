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
    public partial class AdminForm : Form
    {
        private User currentUser;
        private UserDAO userDAO;
        private BindingList<UserDisplay> userDisplayList;

        public AdminForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            userDAO = new UserDAO();
        }

        private void logOutButton_click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            ConfigureDataGridView();
        }

        private void LoadUsers()
        {
            try
            {
                var users = userDAO.GetAll();
                userDisplayList = new BindingList<UserDisplay>();

                foreach (var user in users)
                {
                    userDisplayList.Add(new UserDisplay(user));
                }

                usersDataGridView.DataSource = userDisplayList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            usersDataGridView.AutoGenerateColumns = true;
            usersDataGridView.AllowUserToAddRows = true;
            usersDataGridView.AllowUserToDeleteRows = true;

            usersDataGridView.CellValueChanged += UsersDataGridView_CellValueChanged;
            usersDataGridView.UserDeletingRow += UsersDataGridView_UserDeletingRow;
            usersDataGridView.DefaultValuesNeeded += UsersDataGridView_DefaultValuesNeeded;

            if (usersDataGridView.Columns.Count > 0)
            {
                if (usersDataGridView.Columns["Id"] != null)
                {
                    usersDataGridView.Columns["Id"].ReadOnly = true;
                    usersDataGridView.Columns["Id"].DisplayIndex = 0;
                }

                if (usersDataGridView.Columns["Firstname"] != null)
                    usersDataGridView.Columns["Firstname"].DisplayIndex = 1;

                if (usersDataGridView.Columns["Name"] != null)
                    usersDataGridView.Columns["Name"].DisplayIndex = 2;

                if (usersDataGridView.Columns["Email"] != null)
                    usersDataGridView.Columns["Email"].DisplayIndex = 3;

                if (usersDataGridView.Columns["Password"] != null)
                {
                    usersDataGridView.Columns["Password"].DisplayIndex = 4;
                    usersDataGridView.Columns["Password"].HeaderText = "New Password (leave empty to keep current)";
                }

                if (usersDataGridView.Columns["Admin"] != null)
                {
                    usersDataGridView.Columns["Admin"].DisplayIndex = 5;
                }

                if (usersDataGridView.Columns["Role"] != null)
                    usersDataGridView.Columns["Role"].Visible = false;
            }
        }

        private void UsersDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Admin"].Value = false;
        }

        private void UsersDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= userDisplayList.Count)
                return;

            var userDisplay = userDisplayList[e.RowIndex];

            if (userDisplay.Id == 0)
            {
                CreateNewUser(userDisplay);
            }
            else
            {
                UpdateExistingUser(userDisplay, e.ColumnIndex);
            }
        }

        private void CreateNewUser(UserDisplay userDisplay)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(userDisplay.Email) ||
                    string.IsNullOrWhiteSpace(userDisplay.Password))
                {
                    MessageBox.Show("Email and Password are required for new users.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newUser = new User
                {
                    Firstname = userDisplay.Firstname ?? "",
                    Name = userDisplay.Name ?? "",
                    Email = userDisplay.Email,
                    Role = userDisplay.Admin
                };

                userDAO.Create(newUser, userDisplay.Password);

                MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateExistingUser(UserDisplay userDisplay, int columnIndex)
        {
            try
            {
                var user = new User
                {
                    Id = userDisplay.Id,
                    Firstname = userDisplay.Firstname ?? "",
                    Name = userDisplay.Name ?? "",
                    Email = userDisplay.Email,
                    Role = userDisplay.Admin
                };

                userDAO.Update(user);

                if (!string.IsNullOrWhiteSpace(userDisplay.Password))
                {
                    userDAO.UpdatePasswordByAdmin(user.Id, userDisplay.Password);
                    userDisplay.Password = "";
                }

                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsersDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var userDisplay = e.Row.DataBoundItem as UserDisplay;
            if (userDisplay == null || userDisplay.Id == 0)
                return;

            var result = MessageBox.Show($"Are you sure you want to delete user '{userDisplay.Firstname} {userDisplay.Name}'?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    userDAO.Delete(userDisplay.Id);
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (usersDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usersDataGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one user to delete.", "Multiple Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = usersDataGridView.SelectedRows[0];
            var userDisplay = selectedRow.DataBoundItem as UserDisplay;

            if (userDisplay == null || userDisplay.Id == 0)
            {
                MessageBox.Show("Cannot delete this user.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete user '{userDisplay.Firstname} {userDisplay.Name}'?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    userDAO.Delete(userDisplay.Id);
                    MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            UserCreatorForm userCreatorForm = new UserCreatorForm();
            userCreatorForm.ShowDialog();
            LoadUsers();
        }
    }

    public class UserDisplay
    {
        private User user;

        public UserDisplay()
        {
            user = new User();
        }

        public UserDisplay(User user)
        {
            this.user = user;
        }

        public int Id
        {
            get => user.Id;
            set => user.Id = value;
        }

        public string Firstname
        {
            get => user.Firstname;
            set => user.Firstname = value;
        }

        public string Name
        {
            get => user.Name;
            set => user.Name = value;
        }

        public string Email
        {
            get => user.Email;
            set => user.Email = value;
        }

        public string Password { get; set; }

        public bool Role
        {
            get => user.Role;
            set => user.Role = value;
        }

        public bool Admin
        {
            get => user.Role;
            set => user.Role = value;
        }
    }
}
