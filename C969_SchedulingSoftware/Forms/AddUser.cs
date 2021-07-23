using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseModel;

namespace C969_SchedulingSoftware.Forms
{
    public partial class AddUser : Form
    {
        private U05tp4Entities userContext = new U05tp4Entities();
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            user newUser = new user();

            if (activeCheckBox.Checked)
            {
                newUser.active = 1;
            }
            else
            {
                newUser.active = 0;
            }

            newUser.createDate = DateTime.UtcNow;
            newUser.createdBy = AppInfo.CurrentUser.userName;
            newUser.lastUpdate = DateTime.UtcNow;
            newUser.lastUpdateBy = AppInfo.CurrentUser.userName;
            newUser.password = "0";
            newUser.userName = userNameTextBox.Text;

            if (!UsernameExists(newUser.userName))
            {
                userContext.users.Add(newUser);
                userContext.SaveChanges();
                Password.HashPassword(newUser.userName, passwordTextBox.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void ValidateBoxes()
        {
            bool validUsername = !String.IsNullOrWhiteSpace(userNameTextBox.Text);
            bool validPassword = !String.IsNullOrWhiteSpace(passwordTextBox.Text);
            if (validUsername && validPassword)
            {
                saveButton.Enabled = true;
                userNameTextBox.BackColor = Color.White;
                passwordTextBox.BackColor = Color.White;
            }
            else if (!validUsername)
            {
                saveButton.Enabled = false;
            }
            else if (!validPassword)
            {
                saveButton.Enabled = false;
            }
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateBoxes();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateBoxes();
        }


        private bool UsernameExists(string userName)
        {
            var search = userContext.users
                .Where(u => u.userName == userName)
                .Count();

            if (search != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
