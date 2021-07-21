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
        private appointment appointmentToEdit;
        private int appointmentBindingSourcePosition;

        public EditAppointment(ref U05tp4Entities appointmentDbcontext ,int appointmentIdToEdit, int appointmentBindingSourcePosition)
        {
            InitializeComponent();
            this.appointmentDbcontext = appointmentDbcontext;
            this.appointmentBindingSourcePosition = appointmentBindingSourcePosition;
            this.appointmentToEdit = AppointmentSearch(appointmentIdToEdit);
        }

        private void EditAppointment_Load(object sender, EventArgs e)
        {
            this.appointmentDbcontext.appointments.Load();
            this.appointmentBindingSource.DataSource = appointmentDbcontext.appointments.Local;
            this.appointmentBindingSource.Position = appointmentBindingSourcePosition;
        }

        private appointment AppointmentSearch(int appointmentId)
        {
            var search = appointmentDbcontext.appointments
                .Where(a => a.appointmentId == appointmentId)
                .First();

            return search;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
