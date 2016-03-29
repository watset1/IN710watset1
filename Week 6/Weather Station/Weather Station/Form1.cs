using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Station
{
    public partial class Form1 : Form
    {
        SubjectObserverManager manager;
        String errorMessage;

        public Form1()
        {
            InitializeComponent();

            manager = new SubjectObserverManager(listBoxTemp, listBoxAvg, listBoxForecast);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool errorFree = ErrorChecking();
            if (errorFree)
            {
                ClearDisplay();
                String temperature = txtTemperature.Text;
                String humidity = txtHumidity.Text;
                String barometric = txtBarometric.Text;
                manager.UpdateMeasurements(temperature, humidity, barometric);
            }
            else
            {
                lblError.Text = errorMessage;
            }            
        }

        public void ClearDisplay()
        {           
            listBoxTemp.Items.Clear();
            listBoxAvg.Items.Clear();
            listBoxForecast.Items.Clear();
        }

        public Boolean ErrorChecking()
        {
            int parsedValue;
            if (txtTemperature.Text == "" || txtHumidity.Text == "" || txtBarometric.Text == "")
            {
                errorMessage = "Missing one or more fields";
                return false;
            }
            else if (!int.TryParse(txtTemperature.Text, out parsedValue) || !int.TryParse(txtHumidity.Text, out parsedValue) || !int.TryParse(txtBarometric.Text, out parsedValue))
            {
                errorMessage = "All fields are number only fields";
                return false;
            }
            else if (Convert.ToInt16(txtTemperature.Text) > 60 || Convert.ToInt16(txtTemperature.Text) < -100)
            {
                errorMessage = "Please enter a realistic temperature value";
                return false;
            }
            else if (Convert.ToInt16(txtHumidity.Text) < 0 || Convert.ToInt16(txtHumidity.Text) > 100)
            {
                errorMessage = "Humidity must be between 0% and 100%";
                return false;
            }
            else if (Convert.ToInt16(txtBarometric.Text) < 0 || Convert.ToInt16(txtBarometric.Text) > 1500)
            {
                errorMessage = "Please enter a realistic pressure value";
                return false;
            }
            else
            {
                return true;
            }           
        }       
    }
}
