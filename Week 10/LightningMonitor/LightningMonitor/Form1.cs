using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightningMonitor
{
    public partial class Form1 : Form
    {
        DatabaseManager dbm;

        public Form1()
        {
            InitializeComponent();
            dbm = new DatabaseManager();
        }

        private void btnAverageIntensity_Click(object sender, EventArgs e)
        {
            clearListBox();
            String average = dbm.ComputeAverageIntensity().ToString();
            listBox1.Items.Add("Average intensity of All Lightning Strikes:\t\t        " + average);
        }

        private void clearListBox()
        {
            listBox1.Items.Clear();
        }

        private void btnThreeFires_Click(object sender, EventArgs e)
        {
            clearListBox();
            dbm.GetThreeLargestFires(listBox1);
        }

        private void btnPictureStrike_Click(object sender, EventArgs e)
        {
            clearListBox();
            dbm.GetPictureLatLong(listBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearListBox();
            dbm.GetStrikesCausingFires(listBox1);
        }
    }
}
