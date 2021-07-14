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
using C969_SchedulingSoftware.Forms;

namespace C969_SchedulingSoftware.Forms
{
    public partial class AddCountry : Form
    {
        private DatabaseModel.U05tp4Entities countryDbcontext;// = new DatabaseModel.U05tp4Entities();
        
        public AddCountry(ref DatabaseModel.U05tp4Entities countryDbcontext)
        {   
            InitializeComponent();
            this.countryDbcontext = countryDbcontext;
        }

        private void AddCountry_Load(object sender, EventArgs e)
        {
            countryDbcontext.countries.Load();
            saveButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.UtcNow;
            country newCountry = new country();
            newCountry.country1 = country1TextBox.Text;
            newCountry.createDate = currentDateTime.Date;
            newCountry.createdBy = "test";
            newCountry.lastUpdate = currentDateTime.Date;
            newCountry.lastUpdateBy = "test";

            countryDbcontext.countries.Add(newCountry);
            countryDbcontext.SaveChanges();

            this.Close();

        }

        private void ValidateFields()
        {
            if (String.IsNullOrEmpty(country1TextBox.Text))
            {
                saveButton.Enabled = false;
                country1TextBox.BackColor = Color.Red;
            }
            else
            {
                saveButton.Enabled = true;
                country1TextBox.BackColor = Color.White;
            }
        }

        private void country1TextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }
    }
}
