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
    public partial class AddEditCustomer : Form
    {
        private DatabaseModel.U05tp4Entities addressDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities cityDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities countryDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities customerDbcontext = new DatabaseModel.U05tp4Entities();
        private enum FormType { Add, Edit }
        private customer customerToEdit;
        private FormType formType;
        private int customerBindingSourcePosition;
        public AddEditCustomer(ref U05tp4Entities customerDbcontext)
        {
            InitializeComponent();
            this.customerDbcontext = customerDbcontext;
            this.formType = FormType.Add;
        }
        public AddEditCustomer(int customerIdToEdit, ref U05tp4Entities customerDbcontext, int customerBindingSourcePosition)
        {
            InitializeComponent();
            this.customerDbcontext = customerDbcontext;
            this.formType = FormType.Edit;
            this.customerToEdit = CustomerSearch(customerIdToEdit);
            this.customerBindingSourcePosition = customerBindingSourcePosition;
        }

        private void AddEditCustomer_Load(object sender, EventArgs e)
        {
            addressDbcontext.addresses.Load();
            cityDbcontext.cities.Load();

            cityComboBox.DataSource = cityDbcontext.cities.Local.ToBindingList();


            if (formType == FormType.Edit)
            {
                customerBindingSource.DataSource = customerDbcontext.customers.Local.ToBindingList();
                customerBindingSource.Position = customerBindingSourcePosition;

            }

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (this.formType == FormType.Add)
            {
                AddCustomerSave();
            }
            else
            {
                EditCustomerSave();
            }
            
        
        }

        private address AddressSearch(address addressToSearch)
        {
            try
            {
                var search = addressDbcontext.addresses
                .Where(a => a.address1 == addressToSearch.address1)
                .Where(a => a.address2 == addressToSearch.address2)
                .Where(a => a.cityId == addressToSearch.cityId)
                .Where(a => a.phone == addressToSearch.phone)
                .Where(a => a.postalCode == addressToSearch.postalCode)
                .First();
                return search;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void cityLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var addCityForm = new AddCity(ref cityDbcontext, ref countryDbcontext);
            addCityForm.ShowDialog();
            if (addCityForm.DialogResult == DialogResult.OK)
            {
                int size = cityDbcontext.cities.Local.Count;
                cityComboBox.SelectedItem = cityDbcontext.cities.Local[size - 1];
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            var search = customerDbcontext.cities
                .Where(c => c.cityId == (int)cityComboBox.SelectedValue)
                .First();

            country1TextBox.Text = search.country.country1;

        }
        private void PopulateControls(customer customerToPopulate)
        {
            activeCheckBox.Checked = customerToPopulate.active;
            customerNameTextBox.Text = customerToPopulate.customerName;
            address1TextBox.Text = customerToPopulate.address.address1;
            address2TextBox.Text = customerToPopulate.address.address2;
            cityComboBox.SelectedValue = customerToPopulate.address.cityId;
            phoneTextBox.Text = customerToPopulate.address.phone;
            postalCodeTextBox.Text = customerToPopulate.address.postalCode;
        }

        private void AddCustomerSave()
        {
            DateTime currentDateTime = DateTime.UtcNow;
            address newAddress = new address();
            customer newCustomer = new customer();

            //build new address entry, must be done before new customer added
            newAddress.address1 = address1TextBox.Text;
            newAddress.address2 = address2TextBox.Text;
            newAddress.cityId = (int)cityComboBox.SelectedValue;
            newAddress.createDate = currentDateTime.Date;
            newAddress.createdBy = "test";
            newAddress.lastUpdate = currentDateTime.Date;
            newAddress.lastUpdateBy = "test";
            newAddress.phone = phoneTextBox.Text;
            newAddress.postalCode = postalCodeTextBox.Text;

            newCustomer.active = activeCheckBox.Checked;
            newCustomer.createDate = currentDateTime.Date;
            newCustomer.createdBy = "test";
            newCustomer.customerName = customerNameTextBox.Text;
            newCustomer.lastUpdate = currentDateTime.Date;
            newCustomer.lastUpdateBy = "test";

            var searchResults = AddressSearch(newAddress);


            if (searchResults == null)
            {
                addressDbcontext.addresses.Add(newAddress);
                addressDbcontext.SaveChanges();

                newCustomer.addressId = newAddress.addressId;
            }
            else
            {
                newCustomer.addressId = searchResults.addressId;
            }

            customerDbcontext.customers.Add(newCustomer);
            customerDbcontext.SaveChanges();
            this.DialogResult = DialogResult.OK;

        }
        private void EditCustomerSave()
        {
            DateTime currentDateTime = DateTime.UtcNow;
            address newAddress = new address();
            customer newCustomer = new customer();



            //build new address entry, must be done before new customer added
            newAddress.address1 = address1TextBox.Text;
            newAddress.address2 = address2TextBox.Text;
            newAddress.cityId = (int)cityComboBox.SelectedValue;
            newAddress.createDate = currentDateTime.Date;
            newAddress.createdBy = "test";
            newAddress.lastUpdate = currentDateTime.Date;
            newAddress.lastUpdateBy = "test";
            newAddress.phone = phoneTextBox.Text;
            newAddress.postalCode = postalCodeTextBox.Text;

            newCustomer.active = activeCheckBox.Checked;
            newCustomer.createDate = currentDateTime.Date;
            newCustomer.createdBy = "test";
            newCustomer.customerName = customerNameTextBox.Text;
            newCustomer.lastUpdate = currentDateTime.Date;
            newCustomer.lastUpdateBy = "test";

            var searchResults = AddressSearch(newAddress);


            if (searchResults == null)
            {
                addressDbcontext.addresses.Add(newAddress);
                addressDbcontext.SaveChanges();

                newCustomer.addressId = newAddress.addressId;
            }
            else
            {
                newCustomer.addressId = searchResults.addressId;
            }

            customerDbcontext.customers.Add(newCustomer);
            customerDbcontext.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }

        private customer CustomerSearch(int customerId)
        {
            customer search = customerDbcontext.customers.Local
                .Where(c => c.customerId == customerId)
                .First();

            return search;
        }
    }
}
