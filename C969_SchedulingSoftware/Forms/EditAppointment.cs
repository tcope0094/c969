using DatabaseModel;
using Org.BouncyCastle.Math.Field;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_SchedulingSoftware.Forms
{
    public partial class EditAppointment : Form
    {
        private U05tp4Entities appointmentDbcontext = new U05tp4Entities();
        private U05tp4Entities customerDbcontext = new U05tp4Entities();
        private appointment appointmentToEdit;
        private int appointmentBindingSourcePosition;
        
        public EditAppointment(int appointmentIdToEdit, int appointmentBindingSourcePosition)
        {
            InitializeComponent();
            this.appointmentBindingSourcePosition = appointmentBindingSourcePosition;
            appointmentToEdit = AppointmentSearch(appointmentIdToEdit);
        }

        private void EditAppointment_Load(object sender, EventArgs e)
        {
            appointmentDbcontext.appointments
                .Where(a => a.appointmentId == appointmentToEdit.appointmentId)
                .Load();

            appointmentBindingSource.DataSource = appointmentDbcontext.appointments.Local.ToBindingList();
            appointmentBindingSource.Position = appointmentBindingSourcePosition;

            startDateTimePicker.Format = DateTimePickerFormat.Custom;
            startDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";
            endDateTimePicker.Format = DateTimePickerFormat.Custom;
            endDateTimePicker.CustomFormat = "MM/dd/yyyy hh:mm tt";

            startDateTimePicker.Value = startDateTimePicker.Value.ToLocalTime();
            endDateTimePicker.Value = endDateTimePicker.Value.ToLocalTime();
        }

        private appointment AppointmentSearch(int appointmentId)
        {
            try
            {
                var search = appointmentDbcontext.appointments
                    .Where(a => a.appointmentId == appointmentId)
                    .First();

                return search;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            appointmentBindingSource.CancelEdit();
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (IsValidSchedule())
            {   
                startDateTimePicker.Value = startDateTimePicker.Value.ToUniversalTime();
                endDateTimePicker.Value = endDateTimePicker.Value.ToUniversalTime();
                
                appointmentBindingSource.EndEdit();
                appointmentDbcontext.SaveChanges();

                TimeStamp.Update(appointmentToEdit);

                this.Close();
            }
            else
            {
                appointmentBindingSource.CancelEdit();
            }
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
            bool validWeekday = IsWeekday(startDate);

            string errorMessage = "";

            if (validBusinessHours && validStartEndTime && validStartEndDate && validWeekday)
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
            if (!validWeekday)
            {
                errorMessage += "\nAppointments can only be scheduled Monday - Friday";
            }

            if (valid == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show(errorMessage,"Invalid Schedule",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
        private Func<DateTime, bool> IsWeekday = day => day.DayOfWeek >= DayOfWeek.Monday && day.DayOfWeek <= DayOfWeek.Friday;
    }
}
