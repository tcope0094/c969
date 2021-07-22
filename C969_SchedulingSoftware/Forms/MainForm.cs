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
        
        private DatabaseModel.U05tp4Entities weeklyDbcontext = new DatabaseModel.U05tp4Entities();
        private DatabaseModel.U05tp4Entities monthlyDbcontext = new DatabaseModel.U05tp4Entities();
        public List<DatabaseModel.appointment> UpcomingAppointments { get; private set; }
        
        DateTime now = DateTime.UtcNow;
        
        public MainForm()
        {
            InitializeComponent();
            using (DatabaseModel.U05tp4Entities dbcontext = new DatabaseModel.U05tp4Entities())
            {
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
            weeklyRadioButton.Checked = true;
            WeeklyView();
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

        private void mgrAppointmentsButton_Click(object sender, EventArgs e)
        {
            var manageAppointments = new ManageAppointments();
            manageAppointments.Show();
        }

        private void calendarDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime)
            {
                e.Value = ((DateTime)e.Value).ToLocalTime();
            }
        }

        private void WeeklyView()
        {
            DayOfWeek currentDay = DateTime.Now.DayOfWeek;
            DateTime weekStart;
            DateTime weekEnd;

            if ((int)currentDay == 1)
            {
                weekStart = DateTime.Now.Date;
            }
            else
            {
                weekStart = DateTime.Now.AddDays(((int)currentDay - 1) * -1).Date;
            }
            weekEnd = weekStart.AddDays(4);

            weeklyDbcontext.appointments
                .Where(a => a.start >= weekStart.Date && a.start <= weekEnd.Date)
                .Load();

            appointmentBindingSource.DataSource = weeklyDbcontext.appointments.Local.ToBindingList();

        }

        private void weeklyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            
            if (weeklyRadioButton.Checked)
            {
                WeeklyView();
            }
            else
            {
                MonthlyView();
            }
        }

        private void MonthlyView()
        {
            monthlyDbcontext.appointments.Load();
            appointmentBindingSource.DataSource = monthlyDbcontext.appointments.Local.ToBindingList();
        }
    }
}
