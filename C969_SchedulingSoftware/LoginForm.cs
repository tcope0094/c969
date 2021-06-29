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

namespace C969_SchedulingSoftware
{
    public partial class LoginForm : Form
    {
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

            }
            else if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
