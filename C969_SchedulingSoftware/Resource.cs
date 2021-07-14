using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;

namespace C969_SchedulingSoftware
{
    class Resource
    {
        public static ResourceManager MyResources { get; set; }

        public Resource()
        {
            ResourceManager rm = new ResourceManager("C969_SchedulingSoftware.ResourceFiles.strings", Assembly.GetExecutingAssembly());
            MyResources = rm;
        }
    }
}
