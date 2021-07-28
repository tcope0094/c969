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
                DateTime window = DateTime.UtcNow.AddMinutes(15);

                UpcomingAppointments = dbcontext.appointments
                .Where(appt => appt.userId == AppInfo.CurrentUser.userId)
                .Where(appt => appt.start > now)
                .Where(appt => appt.start <= window)
                .ToList();
            }            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            weeklyRadioButton.Checked = true;
            WeeklyView();
            navGroupBox.Text = $"Welcome {AppInfo.CurrentUser.userName}, what would you like to do?";
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (UpcomingAppointments.Count > 0)
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
            var manageCustomers = new ManageCustomers();
            manageCustomers.Show();
        }

        private void mgrAppointmentsButton_Click(object sender, EventArgs e)
        {
            var manageAppointments = new ManageAppointments();
            manageAppointments.ShowDialog();
            if (manageAppointments.DialogResult == DialogResult.OK)
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
        }

        private void calendarDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime)
            {
                e.Value = ((DateTime)e.Value).ToLocalTime();
            }
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
            weekEnd = weekStart.AddDays(5).AddSeconds(-1);

            weeklyDbcontext.appointments
                .Where(a => a.start >= weekStart.Date && a.start <= weekEnd)
                .Where(a => a.userId == AppInfo.CurrentUser.userId)
                .OrderBy(a => a.start)
                .Load();

            appointmentBindingSource.DataSource = weeklyDbcontext.appointments.Local.ToBindingList();

        }

        private void MonthlyView()
        {
            DateTime currentDay = DateTime.Now;
            DateTime monthStart;
            DateTime monthEnd;

            if ((int)currentDay.Day == 1 && (int)currentDay.DayOfWeek == 1)
            {
                monthStart = DateTime.Now.Date;
            }
            else
            {
                monthStart = DateTime.Now.AddDays(((int)currentDay.Day - 1) * -1).Date;
            }
            monthEnd = monthStart.AddMonths(1).AddDays(-1);
            
            monthlyDbcontext.appointments
                .Where(a => a.start >= monthStart.Date && a.start <= monthEnd.Date)
                .Where(a => a.userId == AppInfo.CurrentUser.userId)
                .OrderBy(a => a.start)
                .Load();

            appointmentBindingSource.DataSource = monthlyDbcontext.appointments.Local.ToBindingList();
        }

        private void viewReportsButton_Click(object sender, EventArgs e)
        {
            var viewReports = new ViewReports();
            viewReports.ShowDialog();
        }

        private void manageUsersButton_Click(object sender, EventArgs e)
        {
            var manageUsers = new ManageUsers();
            manageUsers.ShowDialog();
        }
    }
}
