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

namespace C969_SchedulingSoftware
{
    public partial class MainForm : Form
    {
        public static ResourceManager rm = new ResourceManager("C969_SchedulingSoftware.ResourceFiles.strings", Assembly.GetExecutingAssembly());
        public MainForm(int userID)
        {
            InitializeComponent();
        }
    }
}
