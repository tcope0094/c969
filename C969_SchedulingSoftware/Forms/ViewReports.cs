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
    public partial class ViewReports : Form
    {
        public ViewReports()
        {
            InitializeComponent();
        }

        private void ViewReports_Load(object sender, EventArgs e)
        {

        }

        private void NumTypesByMonth()
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

            reportsOutput.Clear();

            using (U05tp4Entities reportsDbcontext = new U05tp4Entities())
            {
                reportsDbcontext.appointments.Load();

                var query = reportsDbcontext.appointments.Local
                    .Where(a => a.start >= monthStart && a.start <= monthEnd)
                    .GroupBy(a => a.type)
                    .Select(a => new
                    {
                        Type = a.Key,
                        Count = a.Count()
                    }
                    )
                    .OrderByDescending(a => a.Count);

                var output = new StringBuilder();
                output.Append("Number of appointment types this month");
                output.Append(Environment.NewLine);
                output.Append(Environment.NewLine);
                output.Append(String.Format("{0,-15} {1,-10}", "Type:", "Count:"));
                output.Append(Environment.NewLine);
                foreach (var item in query)
                {   
                    output.Append(String.Format("{0,-15} {1,-10}", $"{item.Type}", $"{item.Count}"));
                    output.Append(Environment.NewLine);
                }
                reportsOutput.AppendText(output.ToString());
            }
        }
        private void AllUserSchedules()
        {
            reportsOutput.Clear();

            U05tp4Entities reportsDbcontext = new U05tp4Entities();
            
            reportsDbcontext.appointments.Load();
            reportsDbcontext.users.Load();

            var query = reportsDbcontext.users.Local;

            foreach (var item in query)
            {
                List<appointment> userAppointments = AppointmentSearch(item.userId);
                var sb = new StringBuilder();
                sb.Append($"{item.userName}'s Schedule:{Environment.NewLine}");
                sb.Append(Environment.NewLine);

                if (userAppointments.Count != 0)
                {
                    sb.Append(String.Format("{0,-20} {1,-25} {2,-25} {3,-15} {4,-20}", "Customer:", "Start Time:", "End Time:", "Title:", "Type:"));

                    foreach (var appt in userAppointments)
                    {
                        sb.Append(String.Format("{0,-20} {1,-25} {2,-25} {3,-15} {4,-20}", appt.customer.ToString(), appt.start.ToLocalTime().ToString(), appt.end.ToLocalTime().ToString(), appt.title.ToString(), appt.type.ToString()));
                    }
                }
                else
                {
                    sb.Append("No appointments scheduled for this user");
                }
                reportsOutput.AppendText(sb.ToString());
                reportsOutput.AppendText(Environment.NewLine);
                reportsOutput.AppendText(Environment.NewLine);
            }
            reportsDbcontext.Dispose();
        }
        private void AppointmentsCreatedToday()
        {
            var appointmentsToday = AppointmentSearch(DateTime.Now.Date);
            var sb = new StringBuilder();
            sb.Append($"All appointments created today: {DateTime.Now.ToShortDateString()}");
            sb.Append(Environment.NewLine);

            if (appointmentsToday.Count != 0)
            {
                sb.Append(String.Format("{0,-10} {1,-20} {2,-25} {3,-25} {4,-15} {5,-20}", "User:", "Customer:", "Start Time:", "End Time:", "Title:", "Type:"));
                sb.Append(Environment.NewLine);

                foreach (var appt in appointmentsToday)
                {
                    sb.Append(String.Format("{0,-10} {1,-20} {2,-25} {3,-25} {4,-15} {5,-20}", appt.user.ToString(), appt.customer.ToString(), appt.start.ToLocalTime().ToString(), appt.end.ToLocalTime().ToString(), appt.title.ToString(), appt.type.ToString()));
                    sb.Append(Environment.NewLine);
                }
            }
            else
            {
                sb.Append("No appointments created today");
            }
            reportsOutput.Clear();
            reportsOutput.AppendText(sb.ToString());
            reportsOutput.AppendText(Environment.NewLine);
            reportsOutput.AppendText(Environment.NewLine);
        }

        private void reportTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (reportTypeComboBox.SelectedIndex)
            {
                case 0:
                    NumTypesByMonth();
                    break;

                case 1:
                    AllUserSchedules();
                    break;

                case 2:
                    AppointmentsCreatedToday();
                    break;
            }
        }

        private List<appointment> AppointmentSearch(int userId)
        {
            try
            {
                using (U05tp4Entities searchContext = new U05tp4Entities())
                {
                    return searchContext.appointments
                        .Where(a => a.userId == userId)
                        .Include(a => a.user)
                        .Include(a => a.customer)
                        .ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private List<appointment> AppointmentSearch(DateTime date)
        {
            try
            {
                using (U05tp4Entities searchContext = new U05tp4Entities())
                {
                    return searchContext.appointments
                        .Where(a => a.createDate.Day == date.Day)
                        .Where(a => a.createDate.Month == date.Month)
                        .Where(a => a.createDate.Year == date.Year)
                        .Include(a => a.user)
                        .Include(a => a.customer)
                        .ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
