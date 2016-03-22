using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bicycle_Dashboard
{
    public partial class Form1 : Form
    {
        BicycleSubject bicycleSubject;
        RpmObserver rpmObserver;
        CaloriesPerHourObserver caloriesObserver;
        KmPerHourObserver kmsObserver;
        String errorMessage = "";

        public Form1()
        {
            InitializeComponent();

            bicycleSubject = new BicycleSubject();
            rpmObserver = new RpmObserver(lblRpm, bicycleSubject);
            caloriesObserver = new CaloriesPerHourObserver(lblCalories, bicycleSubject);
            kmsObserver = new KmPerHourObserver(lblKms, bicycleSubject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int parsedValue;
                if (int.TryParse(textBox1.Text, out parsedValue))
                {
                    bicycleSubject.currRpm = Convert.ToInt16(textBox1.Text);
                    bicycleSubject.NotifyObservers();
                    errorMessage = "";
                }
                else
                {
                    errorMessage = "* Please enter a number";
                }
            }
            else
            {
                errorMessage = "* Add RPM field is emtpy.\n  Please enter value.";
            }
            lblError.Text = errorMessage;
        }
    }
}
