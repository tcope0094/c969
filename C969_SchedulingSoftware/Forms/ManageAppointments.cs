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
        private DatabaseModel.U05tp4Entities appointmentDbcontext = new DatabaseModel.U05tp4Entities();
        public ManageAppointments()
        {
            InitializeComponent();
        }

        private void ManageAppointments_Load(object sender, EventArgs e)
        {
            appointmentDbcontext.appointments.Load();
            appointmentBindingSource.DataSource = appointmentDbcontext.appointments.Local;
        }
    }
}
