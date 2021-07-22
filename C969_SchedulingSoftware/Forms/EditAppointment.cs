using DatabaseModel;
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
        private U05tp4Entities appointmentDbcontext;
        private U05tp4Entities customerDbcontext = new U05tp4Entities();
        private appointment appointmentToEdit;
        private int appointmentBindingSourcePosition;
        private DateTime dateTime = new DateTime();

        public EditAppointment(ref U05tp4Entities appointmentDbcontext ,int appointmentIdToEdit, int appointmentBindingSourcePosition)
        {
            InitializeComponent();
            this.appointmentDbcontext = appointmentDbcontext;
            this.appointmentBindingSourcePosition = appointmentBindingSourcePosition;
            appointmentToEdit = AppointmentSearch(appointmentIdToEdit);
        }

        private void EditAppointment_Load(object sender, EventArgs e)
        {
            appointmentDbcontext.appointments.Load();
            appointmentDbcontext.customers.Load();
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
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            TimeSpan startTime = startDateTimePicker.Value.TimeOfDay;
            TimeSpan endTime = endDateTimePicker.Value.TimeOfDay;

            if (InsideBusinessHours(startTime,endTime) && IsValidStartEnd(startTime,endTime))
            {   
                startDateTimePicker.Value = startDateTimePicker.Value.ToUniversalTime();
                endDateTimePicker.Value = endDateTimePicker.Value.ToUniversalTime();
                
                appointmentBindingSource.EndEdit();
                appointmentDbcontext.SaveChanges();

                this.DialogResult = DialogResult.OK;
            }
        }


        private bool InsideBusinessHours(TimeSpan start, TimeSpan end)
        {
            TimeSpan businessStart = new TimeSpan(8, 0, 0);
            TimeSpan businessEnd = new TimeSpan(17, 0, 0);


            if (start < businessStart && end > businessEnd)
            {
                MessageBox.Show("Scheduled start and end times must be between 8AM - 5PM", "Invalid Schedule", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }
        
        // LAMBDA => simpler to write the validation for start time before end time this way
        private Func<TimeSpan, TimeSpan, bool> IsValidStartEnd = (start, end) => start < end;
    }
}
