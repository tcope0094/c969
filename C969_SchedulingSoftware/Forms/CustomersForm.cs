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

namespace C969_SchedulingSoftware
{
    public partial class CustomersForm : Form
    {
        public static ResourceManager rm = new ResourceManager("C969_SchedulingSoftware.ResourceFiles.strings", Assembly.GetExecutingAssembly());

        private DatabaseModel.U05tp4Entities customerDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities addressDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities cityDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities countryDbcontext = new DatabaseModel.U05tp4Entities();
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {   
            customerDbcontext.customers
                .OrderBy(c => c.customerName)
                .Load();
            customerBindingSource.DataSource = customerDbcontext.customers.Local;

            addressDbcontext.addresses.Load();
            addressBindingSource.DataSource = addressDbcontext.addresses.Local.ToBindingList();

            customerDbcontext.cities.Load();
            customerDbcontext.countries.Load();

            //customerGroupBox.Text = rm.GetString("strCustomerManagement");
            //dgvActive.HeaderText = "test";

            var test = customerDataGridView.Rows[0].Cells[0].Value.ToString();
            var currentAddress = addressBindingSource.List.OfType<address>().First(f => f.addressId == int.Parse(test));
            addressBindingSource.Position = addressBindingSource.IndexOf(currentAddress);



        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //addressIdTextBox.Text = AddressSearch().ToString();

            Validate();

            //countryBindingSource.EndEdit();
            //cityBindingSource.EndEdit();
            //addressBindingSource.EndEdit();
            customerBindingSource.EndEdit();
            addressDbcontext.SaveChanges();            

            //try
            //{
            //    countryBindingSource.EndEdit();
            //    dbcontext.SaveChanges();
            //    cityBindingSource.EndEdit();
            //    dbcontext.SaveChanges();
            //    addressBindingSource.EndEdit();
            //    dbcontext.SaveChanges();
            //    customerBindingSource.EndEdit();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.UtcNow;
            address newAddress = new address();

        }

        //private int AddressSearch()
        //{
        //    int addressID = addressDbcontext.addresses
        //        .Where(address => address.address1 == address1TextBox.Text)
        //        .Where(address => address.postalCode == postalCodeTextBox.Text)
        //        .Select(address => address.addressId)
        //        .Single();

        //    return addressID;
        //}

        private void customerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addCustomer = new AddEditCustomer();
            addCustomer.ShowDialog();
            if (addCustomer.DialogResult == DialogResult.OK)
            {
                customerBindingSource.ResetBindings(false);
            }
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();

            customerBindingSource.EndEdit();
            

        }

        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void customerDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var test = customerDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                var currentAddress = addressBindingSource.List.OfType<address>().First(f => f.addressId == int.Parse(test));
                addressBindingSource.Position = addressBindingSource.IndexOf(currentAddress);


            }
            catch (ArgumentOutOfRangeException) { }
            catch (InvalidOperationException) { }
        }
    }
}
