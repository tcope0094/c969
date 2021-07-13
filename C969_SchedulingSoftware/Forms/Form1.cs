using DatabaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_SchedulingSoftware.Forms
{
    public partial class Form1 : Form
    {

        private DatabaseModel.U05tp4Entities dbcontext = new DatabaseModel.U05tp4Entities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbcontext.customers.Load();
            customerBindingSource.DataSource = dbcontext.customers.Local;
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            customerBindingSource.EndEdit();
            dbcontext.SaveChanges();
            
        }
    }
}
