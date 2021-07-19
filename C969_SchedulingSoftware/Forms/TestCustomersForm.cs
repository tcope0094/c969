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
    public partial class TestCustomersForm : Form
    {
        public static ResourceManager rm = new ResourceManager("C969_SchedulingSoftware.ResourceFiles.strings", Assembly.GetExecutingAssembly());

        private DatabaseModel.U05tp4Entities customerDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities addressDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities cityDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities countryDbcontext = new DatabaseModel.U05tp4Entities();
        public TestCustomersForm()
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

            cityDbcontext.cities.Load();
            countryDbcontext.countries.Load();

            //customerGroupBox.Text = rm.GetString("strCustomerManagement");
            //dgvActive.HeaderText = "test";

            var test = customerDataGridView.Rows[0].Cells[0].Value.ToString();
            // var currentAddress = addressBindingSource.List.OfType<address>().First(f => f.addressId == int.Parse(test));
            // addressBindingSource.Position = addressBindingSource.IndexOf(currentAddress);

            cityComboBox.DataSource = cityDbcontext.cities.Local.ToBindingList();
            countryComboBox.DataSource = countryDbcontext.countries.Local.ToBindingList();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            customer currentCustomer = (customer)customerBindingSource.Current;
            var editForm = new EditCustomer(currentCustomer);
            editForm.Show();
            
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            customerBindingSource.EndEdit();
            var entries = customerDbcontext.ChangeTracker.Entries();
            List<System.Data.Entity.Infrastructure.DbEntityEntry> updates = new List<System.Data.Entity.Infrastructure.DbEntityEntry>();
            
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Modified )
                {
                    updates.Add(entry);
                    var a123 = entry.Entity;

                    var asdf = 1;
                }
            }
        }
    }
}
