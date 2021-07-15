using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;

namespace C969_SchedulingSoftware
{
    class AppInfo
    {
        public static ResourceManager MyResources { get; set; }
        public static DatabaseModel.user CurrentUser { get; set; }

        public AppInfo()
        {
            ResourceManager rm = new ResourceManager("C969_SchedulingSoftware.ResourceFiles.strings", Assembly.GetExecutingAssembly());
            MyResources = rm;
        }
    }
}
