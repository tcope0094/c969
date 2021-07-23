using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseModel;

namespace C969_SchedulingSoftware.Forms
{
    public partial class ManageUsers : Form
    {
        private U05tp4Entities userDbcontext = new U05tp4Entities();
        public ManageUsers()
        {
            InitializeComponent();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            updatePasswordButton.Enabled = false;
            userDbcontext.users.Load();
            userBindingSource.DataSource = userDbcontext.users.Local.ToBindingList();
        }

        private void userDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            updatePasswordButton.Enabled = true;
        }

        private void updatePasswordButton_Click(object sender, EventArgs e)
        {
            user userToUpdate = (user)userBindingSource.Current;
            var updatePassword = new UpdatePassword(userToUpdate);
            updatePassword.ShowDialog();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var addUser = new AddUser();
            addUser.ShowDialog();
            if (addUser.DialogResult == DialogResult.OK)
            {
                userDbcontext.users.Load();
                userBindingSource.DataSource = userDbcontext.users.Local.ToBindingList();
            }
        }
    }
}
