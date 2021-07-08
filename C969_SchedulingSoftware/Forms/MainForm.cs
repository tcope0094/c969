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

namespace C969_SchedulingSoftware
{
    public partial class MainForm : Form
    {
        public static ResourceManager rm = new ResourceManager("C969_SchedulingSoftware.ResourceFiles.strings", Assembly.GetExecutingAssembly());
        //private DatabaseModel.U05tp4Entities dbcontext = new DatabaseModel.U05tp4Entities();
        public DatabaseModel.user CurrentUser { get; private set; }
        public List<DatabaseModel.appointment> UpcomingAppointments { get; private set; }

        
        public MainForm(int userID)
        {
            InitializeComponent();
            using (DatabaseModel.U05tp4Entities dbcontext = new DatabaseModel.U05tp4Entities())
            {
                CurrentUser = dbcontext.users
                .Where(user => user.userId == userID)
                .Single();

                DateTime now = DateTime.UtcNow;
                DateTime window = DateTime.UtcNow.AddDays(1);

                UpcomingAppointments = dbcontext.appointments
                .Where(appt => appt.userId == CurrentUser.userId)
                .Where(appt => appt.start > now)
                .Where(appt => appt.start <= window)
                .ToList();
            }            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = rm.GetString("strScheduling");
            navGroupBox.Text = $"{rm.GetString("strWelcome")} {CurrentUser.userName}";

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (UpcomingAppointments != null)
            {
                string apptMessage = $"{rm.GetString("strUpcomingAppointments")}: \n\n";
                using (DatabaseModel.U05tp4Entities dbcontext = new DatabaseModel.U05tp4Entities())
                {
                    foreach (var appt in UpcomingAppointments)
                    {
                        var customer = dbcontext.customers
                            .Where(cust => cust.customerId == appt.customerId)
                            .Single();

                        apptMessage += $"{rm.GetString("strCustomer")}: {customer.customerName} \n{rm.GetString("strType")}: {appt.type} \n{rm.GetString("strTime")}: {appt.start.ToLocalTime()} \n\n\n";
                    }
                }

                MessageBox.Show($"{apptMessage}");
            }
        }
    }
}
