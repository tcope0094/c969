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
    public partial class Form1 : Form
    {        
        private DatabaseModel.U05tp4Entities addressDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities cityDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities countryDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities customerDbcontext = new DatabaseModel.U05tp4Entities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customerDbcontext.customers.Load();
            customerDbcontext.cities.Load();
            customerDbcontext.countries.Load();

            customerBindingSource.DataSource = customerDbcontext.customers.Local.ToBindingList();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            customerBindingSource.EndEdit();
            customerDbcontext.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addCustomer = new AddEditCustomer(ref customerDbcontext);
            addCustomer.ShowDialog();
            if (addCustomer.DialogResult == DialogResult.OK)
            {
                //customerDbcontext = new DatabaseModel.U05tp4Entities();
                //customerDbcontext.customers.Load();
                //customerBindingSource.DataSource = customerDbcontext.customers.Local;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var editCustomer = new AddEditCustomer((customer)customerBindingSource.Current, ref customerDbcontext);
            editCustomer.ShowDialog();
            if (editCustomer.DialogResult == DialogResult.OK)
            {

            }
        }
    }
}
