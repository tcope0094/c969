using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModel;

namespace C969_SchedulingSoftware
{
    public static class ApptValidation
    {
        public static bool AppointmentOverlaps(int customerIdToCheck, DateTime startDate, DateTime endDate)
        {
            using (U05tp4Entities dbcontext = new U05tp4Entities())
            {
                var overlappingStart = dbcontext.appointments
                    .Where(a => a.customerId == customerIdToCheck)
                    .Where(a => startDate >= a.start && startDate < a.end)
                    .Count();

                var overlappingEnd = dbcontext.appointments
                    .Where(a => a.customerId == customerIdToCheck)
                    .Where(a => endDate >= a.start && endDate < a.end)
                    .Count();

                if (overlappingStart > 0 || overlappingEnd > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static bool AppointmentOverlaps(user userToCheck, DateTime startDate, DateTime endDate)
        {
            using (U05tp4Entities dbcontext = new U05tp4Entities())
            {
                var overlappingStart = dbcontext.appointments
                    .Where(a => a.userId == userToCheck.userId)
                    .Where(a => startDate >= a.start && startDate < a.end)
                    .Count();

                var overlappingEnd = dbcontext.appointments
                    .Where(a => a.userId == userToCheck.userId)
                    .Where(a => endDate > a.start && endDate < a.end)
                    .Count();

                if (overlappingStart > 0 || overlappingEnd > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
