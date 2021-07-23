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
    public partial class UpdatePassword : Form
    {
        private user userToUpdate;
        private U05tp4Entities userContext = new U05tp4Entities();


        public UpdatePassword(user userToUpdate)
        {
            InitializeComponent();
            this.userToUpdate = userToUpdate;
        }

        private void UpdatePassword_Load(object sender, EventArgs e)
        {
            userTextBox.Text = userToUpdate.userName;
            saveButton.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Password.HashPassword(userToUpdate.userName, passwordTextBox.Text);
            TimeStamp.Update(userToUpdate);
            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateBoxes();
        }

        private void ValidateBoxes()
        {
            if (String.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                saveButton.Enabled = false;
                passwordTextBox.BackColor = Color.Red;
            }
            else
            {
                saveButton.Enabled = true;
                passwordTextBox.BackColor = Color.White;
            }
        }
    }
}
