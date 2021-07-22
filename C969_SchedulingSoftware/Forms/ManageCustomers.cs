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
using C969_SchedulingSoftware.Forms;

namespace C969_SchedulingSoftware.Forms
{
    public partial class ManageCustomers : Form
    {        
        private DatabaseModel.U05tp4Entities addressDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities cityDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities countryDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities customerDbcontext = new DatabaseModel.U05tp4Entities();
        public ManageCustomers()
        {
            InitializeComponent();
        }
        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            customerDbcontext.customers.Load();
            customerBindingSource.DataSource = customerDbcontext.customers.Local.ToBindingList();

            customerDataGridView.ClearSelection();
            editCustomerButton.Enabled = false;
        }
        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            var addCustomer = new AddEditCustomer(ref customerDbcontext);
            addCustomer.ShowDialog();
            if (addCustomer.DialogResult == DialogResult.OK)
            {
                customerDbcontext.customers.Load();
                customerBindingSource.DataSource = customerDbcontext.customers.Local.ToBindingList();
            }
        }
        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            customer customerToEdit = (customer)customerBindingSource.Current;
            var editCustomer = new AddEditCustomer(customerToEdit.customerId, ref customerDbcontext, customerBindingSource.Position);
            editCustomer.ShowDialog();
            if (editCustomer.DialogResult == DialogResult.OK)
            {
                customerDbcontext.customers.Load();
                customerBindingSource.DataSource = customerDbcontext.customers.Local.ToBindingList();
            }
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmationBox = MessageBox.Show("Are you sure you want to delete this customer?","Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (confirmationBox == DialogResult.Yes)
            {
                customerBindingSource.RemoveCurrent();
                customerBindingSource.EndEdit();
                customerDbcontext.SaveChanges();
            }
        }

        private void customerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            editCustomerButton.Enabled = true;
        }
    }
}
