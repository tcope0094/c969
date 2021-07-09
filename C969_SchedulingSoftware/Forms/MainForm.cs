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

namespace C969_SchedulingSoftware
{
    public partial class MainForm : Form
    {
        public static ResourceManager rm = new ResourceManager("C969_SchedulingSoftware.ResourceFiles.strings", Assembly.GetExecutingAssembly());
        //private DatabaseModel.U05tp4Entities dbcontext = new DatabaseModel.U05tp4Entities();
        public DatabaseModel.user CurrentUser { get; private set; }
        public List<DatabaseModel.appointment> UpcomingAppointments { get; private set; }

        
        public MainForm(DatabaseModel.user user)
        {
            InitializeComponent();
            using (DatabaseModel.U05tp4Entities dbcontext = new DatabaseModel.U05tp4Entities())
            {
                CurrentUser = user;

                DateTime now = DateTime.UtcNow;
                DateTime window = DateTime.UtcNow.AddDays(1);

                //commented out so it doesn't pop up while testing
                //UpcomingAppointments = dbcontext.appointments
                //.Where(appt => appt.userId == CurrentUser.userId)
                //.Where(appt => appt.start > now)
                //.Where(appt => appt.start <= window)
                //.ToList();
            }            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = rm.GetString("strScheduling");
            navGroupBox.Text = $"{rm.GetString("strWelcome")} {CurrentUser.userName} {rm.GetString("strWWYLTD")}";
            mgrAppointmentsButton.Text = $"{rm.GetString("strManageAppointments")}";
            mgrCustomerButton.Text = $"{rm.GetString("strManageCustomers")}";
            viewReportsButton.Text = $"{rm.GetString("strViewReports")}";
            calendarGroupBox.Text = $"{rm.GetString("strCalendar")}";
            weeklyRadioButton.Text = $"{rm.GetString("strWeekly")}";
            monthlyRadioButton.Text = $"{rm.GetString("strMonthly")}";
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (UpcomingAppointments != null)
            {
                string apptMessage = null;
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

                MessageBox.Show($"{apptMessage}",$"{rm.GetString("strUpcomingAppointments")}");
            }
        }

        private void mgrCustomerButton_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomersForm(CurrentUser);
            customerForm.Show();
        }
    }
}
