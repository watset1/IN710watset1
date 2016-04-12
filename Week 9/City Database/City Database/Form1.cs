using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_Database
{
    public partial class Form1 : Form
    {
        public delegate SearchResult Func<in T, out SearchResult>();
        List<City> cityList;


        public Form1()
        {
            InitializeComponent();
            cityList = new List<City>();
            populateCityList();
            populateComboBox();
        }

        private void populateCityList()
        {
            cityList.Add(new City("Auckland", "New Zealand", 1377000));
            cityList.Add(new City("Hamilton", "New Zealand", 224000));
            cityList.Add(new City("Wellington", "New Zealand", 398300));
            cityList.Add(new City("Christchurch", "New Zealand", 381800));
            cityList.Add(new City("Dunedin", "New Zealand", 117400));
            cityList.Add(new City("Brisbane", "Australia", 2274560));
            cityList.Add(new City("Sydney", "Australia", 4840628));
            cityList.Add(new City("Melbourne", "Australia", 4440328));
            cityList.Add(new City("Perth", "Australia", 2021203));
            cityList.Add(new City("Adelaide", "Australia", 1304631));
            cityList.Add(new City("Cape Town", "South Africa", 3433441));
            cityList.Add(new City("Johannesburg", "South Africa", 2026469));
            cityList.Add(new City("Durban", "South Africa", 3120282));
            cityList.Add(new City("Soweto", "South Africa", 1695047));
            cityList.Add(new City("Pretoria", "South Africa", 1619438));
        }

        private void populateComboBox()
        {
            cityList.ForEach(c => {if (!comboBox1.Items.Contains(c.CountryName)) { comboBox1.Items.Add(c.CountryName); } });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("=======================================================================");
            listBox1.Items.Add(String.Format("{0,-15}\t{1,15}\t{2,15}", "City", "Population", "Country"));
            listBox1.Items.Add("=======================================================================");
            String country = comboBox1.Text.ToString();
            cityList.ForEach(c => { if (c.CountryName == country) { listBox1.Items.Add(c.ToString()); } });
        } 

        private void populationChangeMethod()
        {
            cityList.ForEach(c => c.Population *= 3);
            cityList.ForEach(c => listBox1.Items.Add(c.ToString()));
        }

        //This method uses only one line of code to do same as above
        private void alternatePopulationChangeMethod()
        {
            cityList.ForEach(c => {c.Population *= 3; listBox1.Items.Add(c.ToString()); });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            populationChangeMethod();
        }
    }
}
