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

namespace C969_SchedulingSoftware.Forms
{
    public partial class EditAppointment : Form
    {
        private appointment appointmentToEdit;
        private int appointmentBindingSourcePosition;

        public EditAppointment(appointment appointmentToEdit, int appointmentBindingSourcePosition)
        {
            InitializeComponent();
            this.appointmentToEdit = appointmentToEdit;
            this.appointmentBindingSourcePosition = appointmentBindingSourcePosition;

        }

        private void EditAppointment_Load(object sender, EventArgs e)
        {

        }
    }
}
