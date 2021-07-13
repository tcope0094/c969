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
    public partial class CustomersForm : Form
    {
        public DatabaseModel.user CurrentUser { get; private set; }
        public static ResourceManager rm = new ResourceManager("C969_SchedulingSoftware.ResourceFiles.strings", Assembly.GetExecutingAssembly());
        private DatabaseModel.U05tp4Entities dbcontext = new DatabaseModel.U05tp4Entities();
        public CustomersForm(DatabaseModel.user user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {   
            dbcontext.customers
                .Load();
            customerBindingSource.DataSource = dbcontext.customers.Local;

            dbcontext.addresses.Load();
            dbcontext.cities.Load();
            dbcontext.countries.Load();

            customerGroupBox.Text = rm.GetString("strCustomerManagement");
            dgvActive.HeaderText = "test";


        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //addressIdTextBox.Text = AddressSearch().ToString();

            Validate();

            countryBindingSource.EndEdit();
            dbcontext.SaveChanges();
            cityBindingSource.EndEdit();
            dbcontext.SaveChanges();
            addressBindingSource.EndEdit();
            dbcontext.SaveChanges();
            customerBindingSource.EndEdit();

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


        }

        private int AddressSearch()
        {
            int addressID = dbcontext.addresses
                .Where(address => address.address1 == address1TextBox.Text)
                .Where(address => address.postalCode == postalCodeTextBox.Text)
                .Select(address => address.addressId)
                .Single();

            return addressID;
        }
    }
}
