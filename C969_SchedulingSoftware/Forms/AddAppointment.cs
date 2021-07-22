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
            startDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";

            startDateTimePicker.Value = startDateTimePicker.Value.ToLocalTime();
            endDateTimePicker.Value = endDateTimePicker.Value.ToLocalTime();
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
                if (IsValidSchedule())
                {
                    startDateTimePicker.Value = startDateTimePicker.Value.ToUniversalTime();
                    endDateTimePicker.Value = endDateTimePicker.Value.ToUniversalTime();

                    appointmentDbcontext.SaveChanges();

                    this.DialogResult = DialogResult.OK;
                }
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
        private bool IsValidSchedule()
        {
            TimeSpan startTime = startDateTimePicker.Value.TimeOfDay;
            TimeSpan endTime = endDateTimePicker.Value.TimeOfDay;
            DateTime startDate = startDateTimePicker.Value.Date;
            DateTime endDate = endDateTimePicker.Value.Date;
            bool valid = false;

            bool validBusinessHours = IsInsideBusinessHours(startTime, endTime);
            bool validStartEndTime = IsValidStartEndTime(startTime, endTime);
            bool validStartEndDate = IsValidStartEndDate(startDate, endDate);

            string errorMessage = "";

            if (validBusinessHours && validStartEndTime && validStartEndDate)
            {
                valid = true;
            }
            if (!validBusinessHours)
            {
                errorMessage += "\nStart and End times must fall between 8AM - 5PM";
            }
            if (!validStartEndTime)
            {
                errorMessage += "\nStart time must be before End time";
            }
            if (!validStartEndDate)
            {
                errorMessage += "\nStart and End dates cannot span multiple days";
            }

            if (valid == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show(errorMessage, "Invalid Schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

        private bool IsInsideBusinessHours(TimeSpan start, TimeSpan end)
        {
            TimeSpan businessStart = new TimeSpan(8, 0, 0);
            TimeSpan businessEnd = new TimeSpan(17, 0, 0);


            if (start >= businessStart && end <= businessEnd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // LAMBDA => simpler to write the validation for start time before end time this way
        private Func<TimeSpan, TimeSpan, bool> IsValidStartEndTime = (start, end) => start < end;
        private Func<DateTime, DateTime, bool> IsValidStartEndDate = (start, end) => start == end;
    }
}
