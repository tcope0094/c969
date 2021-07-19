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
        
        //private DatabaseModel.U05tp4Entities dbcontext = new DatabaseModel.U05tp4Entities();
        public List<DatabaseModel.appointment> UpcomingAppointments { get; private set; }

        
        public MainForm()
        {
            InitializeComponent();
            using (DatabaseModel.U05tp4Entities dbcontext = new DatabaseModel.U05tp4Entities())
            {

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
            this.Text = AppInfo.MyResources.GetString("strScheduling");
            navGroupBox.Text = $"{AppInfo.MyResources.GetString("strWelcome")} {AppInfo.CurrentUser.userName} {AppInfo.MyResources.GetString("strWWYLTD")}";
            mgrAppointmentsButton.Text = $"{AppInfo.MyResources.GetString("strManageAppointments")}";
            mgrCustomerButton.Text = $"{AppInfo.MyResources.GetString("strManageCustomers")}";
            viewReportsButton.Text = $"{AppInfo.MyResources.GetString("strViewReports")}";
            calendarGroupBox.Text = $"{AppInfo.MyResources.GetString("strCalendar")}";
            weeklyRadioButton.Text = $"{AppInfo.MyResources.GetString("strWeekly")}";
            monthlyRadioButton.Text = $"{AppInfo.MyResources.GetString("strMonthly")}";
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

                        apptMessage += $"{AppInfo.MyResources.GetString("strCustomer")}: {customer.customerName} \n{AppInfo.MyResources.GetString("strType")}: {appt.type} \n{AppInfo.MyResources.GetString("strTime")}: {appt.start.ToLocalTime()} \n\n\n";
                    }
                }

                MessageBox.Show($"{apptMessage}",$"{AppInfo.MyResources.GetString("strUpcomingAppointments")}");
            }
        }

        private void mgrCustomerButton_Click(object sender, EventArgs e)
        {
            //var customersForm = new CustomersForm();
            //customersForm.Show();
            var form1 = new ManageCustomers();
            form1.Show();
        }
    }
}
