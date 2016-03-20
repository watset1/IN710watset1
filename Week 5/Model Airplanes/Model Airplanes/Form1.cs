using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model_Airplanes
{
    public partial class Form1 : Form
    {
        AirplanePrinter printer;

        public Form1()
        {
            InitializeComponent();
            displayOptions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                lblError.Text = "";
                String wingString = comboBox1.Text;
                String bodyString = comboBox2.Text;
                String tailString = comboBox3.Text;

                printer = new AirplanePrinter();

                printer.printWing(wingString, pictureBox1);
                printer.printBody(bodyString, pictureBox2);
                printer.printTail(tailString, pictureBox3);
            }
            else
            {
                String errorMessage = "* Not all fields have been chosen.";
                lblError.Text = errorMessage;
            }
        }

        public void displayOptions()
        {
            comboBox1.Items.Add("Red Wing");
            comboBox1.Items.Add("Blue Wing");
            comboBox1.Items.Add("Black Wing");

            comboBox2.Items.Add("Red Body");
            comboBox2.Items.Add("Blue Body");
            comboBox2.Items.Add("Black Body");

            comboBox3.Items.Add("Red Tail");
            comboBox3.Items.Add("Blue Tail");
            comboBox3.Items.Add("Black Tail");
        }
    }
}
