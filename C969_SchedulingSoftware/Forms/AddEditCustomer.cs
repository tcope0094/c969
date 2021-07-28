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
        private address addressToEdit;
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
            customerDbcontext.cities.Load();
            
            if (formType == FormType.Edit)
            {
                customerBindingSource.DataSource = customerDbcontext.customers.Local.ToBindingList();
                customerBindingSource.Position = customerBindingSourcePosition;
                cityComboBox.DataSource = customerDbcontext.cities.Local.ToBindingList();
                cityComboBox.SelectedValue = customerToEdit.address.cityId;
                this.Text = "Edit Customer";
            }
            else
            {
                cityComboBox.DataSource = cityDbcontext.cities.Local.ToBindingList();
                this.Text = "Add Customer";
            }

            saveButton.Enabled = false;

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
            saveButton.Enabled = true;
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
            if ((int)cityComboBox.SelectedValue != customerToEdit.address.cityId)
            {
                addressToEdit = customerDbcontext.addresses
                    .Where(a => a.addressId == customerToEdit.addressId)
                    .First();

                addressToEdit.cityId = (int)cityComboBox.SelectedValue;

            }
            //customerToEdit.lastUpdate = DateTime.UtcNow;
            //customerToEdit.lastUpdateBy = AppInfo.CurrentUser.userName;
            
            customerDbcontext.SaveChanges();
            //TimeStamp.Update(customerToEdit);
            //TimeStamp.Update(addressToEdit);
            this.DialogResult = DialogResult.OK;
        }

        private customer CustomerSearch(int customerId)
        {
            customer search = customerDbcontext.customers.Local
                .Where(c => c.customerId == customerId)
                .First();

            return search;
        }
        private void ValidateBoxes()
        {
            List<TextBox> allBoxes = new List<TextBox>();

            foreach (Control item in this.Controls)
            {
                if (item is TextBox && item.Tag != "not required")
                {
                    allBoxes.Add((TextBox)item);
                }
            }

            var failures = allBoxes
                .Where(a => String.IsNullOrWhiteSpace(a.Text))
                .ToList();

            var successes = allBoxes
                .Where(a => !failures.Any(f => f.Name == a.Name))
                .ToList();

            if (failures.Count == 0)
            {
                saveButton.Enabled = true;
                foreach (var item in allBoxes)
                {
                    item.BackColor = Color.White;
                }
            }
            else
            {
                saveButton.Enabled = false;
                foreach (var s in successes)
                {
                    s.BackColor = Color.White;
                }
                foreach (var f in failures)
                {
                    f.BackColor = Color.Red;
                }
            }
        }

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateBoxes();
        }

        private void address1TextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateBoxes();
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateBoxes();
        }

        private void postalCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateBoxes();
        }

        private void activeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
        }
    }
}
