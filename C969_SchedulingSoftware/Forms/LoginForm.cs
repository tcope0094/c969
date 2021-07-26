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
using DatabaseModel;

namespace C969_SchedulingSoftware
{
    public partial class LoginForm : Form
    {

        public DatabaseModel.user CurrentUser { get; private set; }

        //public static ResourceManager rm = new ResourceManager("C969_SchedulingSoftware.ResourceFiles.strings", Assembly.GetExecutingAssembly());
        private DatabaseModel.U05tp4Entities dbcontext = new DatabaseModel.U05tp4Entities();

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = AppInfo.MyResources.GetString("strUsername");
            passwordLabel.Text = AppInfo.MyResources.GetString("strPassword");
            loginButton.Text = AppInfo.MyResources.GetString("strLogin");
            exitButton.Text = AppInfo.MyResources.GetString("strExit");
            loginButton.Enabled = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SubmitLogin();
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
        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            ValidateLoginBoxes();
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            ValidateLoginBoxes();
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

        private void SubmitLogin()
        {
            try
            {
                bool passwordVerified = Password.VerifyPassword(usernameBox.Text, passwordBox.Text);
                if (!passwordVerified)
                {
                    throw new InvalidOperationException();
                }
                var loginUser = dbcontext.users
                    .Where(user => user.userName == usernameBox.Text && user.active == 1)
                    .Single();

                if (loginUser != null && passwordVerified)
                {
                    AppInfo.CurrentUser = loginUser;
                    LogFile.Login(LoginType.Success, loginUser.userName);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (InvalidOperationException)
            {
                LogFile.Login(LoginType.Failure, usernameBox.Text);
                MessageBox.Show(AppInfo.MyResources.GetString("strLoginFailed"),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)
        {
            user user;
            using (U05tp4Entities context = new U05tp4Entities())
            {
                user = context.users
                    .Where(u => u.userName == "test")
                    .Single();
            }
            Password.HashPassword(user.userName, "test");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user user;
            using (U05tp4Entities context = new U05tp4Entities())
            {
                user = context.users
                    .Where(u => u.userName == "tyler")
                    .Single();
            }
            bool verified = Password.VerifyPassword(user.userName, passwordBox.Text);
            if (verified)
            {
                MessageBox.Show("PASS");
            }
            else
            {
                MessageBox.Show("FAIL");
            }
        }
    }
}
