using DatabaseModel;
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
    public partial class EditCustomer : Form
    {
        private DatabaseModel.U05tp4Entities addressDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities cityDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities countryDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities customerDbcontext = new DatabaseModel.U05tp4Entities();
        public customer customerToEdit;
        public EditCustomer(customer customerToEdit)
        {
            InitializeComponent();
            this.customerToEdit = customerToEdit;
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            addressDbcontext.addresses.Load();
            cityDbcontext.cities.Load();
            countryDbcontext.countries
                .OrderBy(c => c.country1)
                .Load();
            countryComboBox.DataSource = countryDbcontext.countries.Local.ToBindingList();
            cityComboBox.DataSource = cityDbcontext.cities.Local.ToBindingList();
            PopulateControls(customerToEdit);
        }

        private void PopulateControls(customer customerToPopulate)
        {
            activeCheckBox.Checked = customerToPopulate.active;
            customerNameTextBox.Text = customerToPopulate.customerName;
            address1TextBox.Text = customerToPopulate.address.address1;
            address2TextBox.Text = customerToPopulate.address.address2;
            cityComboBox.SelectedValue = customerToPopulate.address.cityId;
            countryComboBox.SelectedValue = customerToPopulate.address.city.countryId ;
            phoneTextBox.Text = customerToPopulate.address.phone;
            postalCodeTextBox.Text = customerToPopulate.address.postalCode;
            


        }
    }
}
