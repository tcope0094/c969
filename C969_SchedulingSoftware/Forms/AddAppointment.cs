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
            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm";
            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm";
        }

        private void addCustomerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var addCustomer = new AddEditCustomer(ref appointmentDbcontext);
            addCustomer.ShowDialog();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            appointment newAppointment = new appointment();
            DateTime currentDateTime = DateTime.UtcNow;

            
            newAppointment.customerId = (int)customerIdComboBox.SelectedValue;
            newAppointment.contact = contactTextBox.Text;
            newAppointment.title = titleTextBox.Text;
            newAppointment.type = typeTextBox.Text;
            newAppointment.description = descriptionTextBox.Text;
            newAppointment.start = startDateTimePicker.Value;
            newAppointment.end = endDateTimePicker.Value;
            newAppointment.location = locationTextBox.Text;
            newAppointment.url = urlTextBox.Text;
            newAppointment.userId = AppInfo.CurrentUser.userId;

            newAppointment.createDate = currentDateTime;
            newAppointment.createdBy = AppInfo.CurrentUser.userName;
            newAppointment.lastUpdate = currentDateTime;
            newAppointment.lastUpdateBy = AppInfo.CurrentUser.userName;

            appointmentDbcontext.appointments.Add(newAppointment);
            try
            {
                appointmentDbcontext.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
