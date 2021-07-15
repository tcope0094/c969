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
        private DatabaseModel.U05tp4Entities cityDbcontext;// = new DatabaseModel.U05tp4Entities();
        public DatabaseModel.U05tp4Entities countryDbcontext;// = new DatabaseModel.U05tp4Entities();
        public AddCity(ref DatabaseModel.U05tp4Entities cityDbcontext, ref DatabaseModel.U05tp4Entities countryDbcontext)
        {
            InitializeComponent();
            this.cityDbcontext = cityDbcontext;
            this.countryDbcontext = countryDbcontext;
        }

        /// //////////////////
        /// Event handlers ///
        //////////////////////
        
        private void countryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var addCountryForm = new AddCountry(ref countryDbcontext);
            addCountryForm.Owner = this;
            addCountryForm.ShowDialog();
            if (addCountryForm.DialogResult == DialogResult.OK)
            {
                int size = countryDbcontext.countries.Local.Count;
                countryComboBox.SelectedItem = countryDbcontext.countries.Local[size - 1];
            }
        }

        private void AddCity_Load(object sender, EventArgs e)
        {
            cityDbcontext.cities.Load();
            countryDbcontext.countries
                .OrderBy(c => c.country1)
                .Load();

            countryComboBox.DataSource = countryDbcontext.countries.Local.ToBindingList();
            saveButton.Enabled = false;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.UtcNow;

            city newCity = new city();
            newCity.city1 = city1TextBox.Text;
            newCity.countryId = (int)countryComboBox.SelectedValue;
            newCity.createDate = currentDateTime.Date;
            newCity.createdBy = AppInfo.CurrentUser.userName;
            newCity.lastUpdate = currentDateTime.Date;
            newCity.lastUpdateBy = AppInfo.CurrentUser.userName;
            city searchResult = AddressSearch(newCity);
            
            try
            {
                if (searchResult == null)
                {
                    cityDbcontext.cities.Add(newCity);
                    cityDbcontext.SaveChanges();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("City and Country combo already exists");
                    this.Close();
                }
                
            }
            catch (Exception)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void city1TextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// /////////////////
        ////// Methods //////
        /////////////////////        

        private city AddressSearch(city cityToSearch)
        {
            try
            {
                var search = cityDbcontext.cities
                    .Where(c => c.city1 == cityToSearch.city1)
                    .Where(c => c.countryId == cityToSearch.countryId)
                    .First();

                return search;
            }
            catch (Exception)
            {
                return null;
            }
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
    }
}
