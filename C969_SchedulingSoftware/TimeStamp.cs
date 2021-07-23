using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseModel;

namespace C969_SchedulingSoftware
{
    public static class TimeStamp
    {

        public static void Update(user entity)
        {
            using (U05tp4Entities dbcontext = new U05tp4Entities())
            {
                var update = dbcontext.users
                    .Where(u => u.userId == entity.userId)
                    .Single();

                update.lastUpdate = DateTime.UtcNow;
                update.lastUpdateBy = AppInfo.CurrentUser.userName;
                dbcontext.SaveChanges();
            }
        }
        public static void Update(address entity)
        {
            using (U05tp4Entities dbcontext = new U05tp4Entities())
            {
                var update = dbcontext.addresses
                    .Where(a => a.addressId == entity.addressId)
                    .Single();

                update.lastUpdate = DateTime.UtcNow;
                update.lastUpdateBy = AppInfo.CurrentUser.userName;
                dbcontext.SaveChanges();
            }
        }
        public static void Update(appointment entity)
        {
            using (U05tp4Entities dbcontext = new U05tp4Entities())
            {
                var update = dbcontext.appointments
                    .Where(a => a.appointmentId == entity.appointmentId)
                    .Single();

                update.lastUpdate = DateTime.UtcNow;
                update.lastUpdateBy = AppInfo.CurrentUser.userName;
                dbcontext.SaveChanges();
            }
        }
        public static void Update(city entity)
        {
            using (U05tp4Entities dbcontext = new U05tp4Entities())
            {
                var update = dbcontext.cities
                    .Where(a => a.cityId == entity.cityId)
                    .Single();

                update.lastUpdate = DateTime.UtcNow;
                update.lastUpdateBy = AppInfo.CurrentUser.userName;
                dbcontext.SaveChanges();
            }
        }
        public static void Update(country entity)
        {
            using (U05tp4Entities dbcontext = new U05tp4Entities())
            {
                var update = dbcontext.countries
                    .Where(a => a.countryId == entity.countryId)
                    .Single();

                update.lastUpdate = DateTime.UtcNow;
                update.lastUpdateBy = AppInfo.CurrentUser.userName;
                dbcontext.SaveChanges();
            }
        }
        public static void Update(customer entity)
        {
            using (U05tp4Entities dbcontext = new U05tp4Entities())
            {
                var update = dbcontext.customers
                    .Where(a => a.customerId == entity.customerId)
                    .Single();

                update.lastUpdate = DateTime.UtcNow;
                update.lastUpdateBy = AppInfo.CurrentUser.userName;
                dbcontext.SaveChanges();
            }
        }

    }
}
