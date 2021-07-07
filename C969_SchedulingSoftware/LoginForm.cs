using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Globalization;
using System.Data.Entity;
using MySql.Data.MySqlClient;
using C969_SchedulingSoftware.Properties;
using System.Reflection;

namespace C969_SchedulingSoftware
{
    public partial class LoginForm : Form
    {

        public static ResourceManager rm = new ResourceManager("C969_SchedulingSoftware.ResourceFiles.strings", Assembly.GetExecutingAssembly());

        public LoginForm()
        {
            InitializeComponent();            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            ParseKeys(e);
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            ParseKeys(e);
        }

        private void usernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            ParseKeys(e);
        }

        private void ParseKeys(KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SubmitLogin();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SubmitLogin();
        }

        private void SubmitLogin()
        {
            using (var dbcontext = new DatabaseModel.U05tp4Entities())
            {
                try
                {
                    var loginUser = dbcontext.users
                        .Where(user => user.userName == usernameBox.Text && user.password == passwordBox.Text && user.active == 1)
                        .Single();
                    if (loginUser != null)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show(rm.GetString("strLoginFailed"),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateLoginBoxes()
        {
            if (String.IsNullOrEmpty(usernameBox.Text) || String.IsNullOrEmpty(passwordBox.Text))
            {
                loginButton.Enabled = false;
                return false;
            }
            else
            {
                loginButton.Enabled = true;
                return true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {            
            usernameLabel.Text = rm.GetString("strUsername");
            passwordLabel.Text = rm.GetString("strPassword");
            loginButton.Text = rm.GetString("strLogin");
            exitButton.Text = rm.GetString("strExit");
            loginButton.Enabled = false;
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            ValidateLoginBoxes();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            ValidateLoginBoxes();
        }
    }
}
