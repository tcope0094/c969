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
using System.Runtime.CompilerServices;
using C969_SchedulingSoftware.Forms;

namespace C969_SchedulingSoftware.Forms
{
    public partial class AddAppointment : Form
    {
        private U05tp4Entities appointmentDbcontext = new U05tp4Entities();
        public AddAppointment()
        {
            InitializeComponent();
        }


        private void AddEditAppointment_Load(object sender, EventArgs e)
        {
            appointmentDbcontext.appointments.Load();
            appointmentDbcontext.customers.Load();

            customerIdComboBox.DataSource = appointmentDbcontext.customers.Local.ToBindingList();

        }

        private void addCustomerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var addCustomer = new AddEditCustomer(ref appointmentDbcontext);
            addCustomer.ShowDialog();
        }
    }
}
