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
    public partial class ManageAppointments : Form
    {
        private U05tp4Entities appointmentDbcontext = new U05tp4Entities();
        public ManageAppointments()
        {
            InitializeComponent();
        }

        private void ManageAppointments_Load(object sender, EventArgs e)
        {
            appointmentDbcontext.appointments
                .Where(a => a.userId == AppInfo.CurrentUser.userId)
                .OrderBy(a => a.start)
                .Load();

            appointmentBindingSource.DataSource = appointmentDbcontext.appointments.Local.ToBindingList();
            dgvStartColumn.DefaultCellStyle.Format = "MM/dd/yyy hh:mm:ss tt";
            dgvEndColumn.DefaultCellStyle.Format = "MM/dd/yyy hh:mm:ss tt";

            editButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addAppointmentForm = new AddAppointment();
            addAppointmentForm.ShowDialog();
            if(addAppointmentForm.DialogResult == DialogResult.OK)
            {
                appointmentDbcontext.appointments
                .Where(a => a.userId == AppInfo.CurrentUser.userId)
                .OrderBy(a => a.start)
                .Load();

                appointmentBindingSource.DataSource = appointmentDbcontext.appointments.Local.ToBindingList();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult deleteConfirm = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (deleteConfirm == DialogResult.Yes)
            {
                appointmentBindingSource.RemoveCurrent();
                appointmentBindingSource.EndEdit();
                appointmentDbcontext.SaveChanges();
            }
            else
            {

            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            appointment appointmentToEdit = (appointment)appointmentBindingSource.Current;
            var editAppointmentForm = new EditAppointment(appointmentToEdit.appointmentId, (int)appointmentBindingSource.Position);
            editAppointmentForm.Show();
        }

        private void appointmentDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value is DateTime)
            {
                e.Value = ((DateTime)e.Value).ToLocalTime();
            }
        }

        private void appointmentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
        }
    }
}
