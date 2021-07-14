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
    public partial class AddCity : Form
    {
        private DatabaseModel.U05tp4Entities cityDbcontext = new DatabaseModel.U05tp4Entities();
        public DatabaseModel.U05tp4Entities countryDbcontext = new DatabaseModel.U05tp4Entities();
        public AddCity()
        {
            InitializeComponent();
        }

        private void countryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var addCountryForm = new AddCountry(ref countryDbcontext);
            addCountryForm.Show();
        }

        private void AddCity_Load(object sender, EventArgs e)
        {
            cityDbcontext.cities.Load();
            countryDbcontext.countries.Load();

            countryComboBox.DataSource = countryDbcontext.countries.Local;
            saveButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void ValidateFields()
        {
            if (String.IsNullOrEmpty(city1TextBox.Text))
            {
                saveButton.Enabled = false;
                city1TextBox.BackColor = Color.Red;
            }
            else
            {
                saveButton.Enabled = true;
                city1TextBox.BackColor = Color.White;
            }
        }

        private void city1TextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }
    }
}
