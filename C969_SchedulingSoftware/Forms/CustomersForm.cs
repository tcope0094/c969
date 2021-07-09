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
    public partial class CustomersForm : Form
    {
        public static ResourceManager rm = new ResourceManager("C969_SchedulingSoftware.ResourceFiles.strings", Assembly.GetExecutingAssembly());
        private DatabaseModel.U05tp4Entities dbcontext = new DatabaseModel.U05tp4Entities();
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            customerGroupBox.Text = rm.GetString("strCustomerManagement");

            dbcontext.customers
                .Load();

            customerBindingSource.DataSource = dbcontext.customers.Local;

        }
    }
}
