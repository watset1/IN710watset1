using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenReporter2016
{
    public partial class Form1 : Form
    {
        DisplayManager displayManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayManager = new DisplayManager();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            displayManager.generateReport("area");
            displayManager.displayReport(listBox1);
        }

        private void btnCharges_Click(object sender, EventArgs e)
        {
            displayManager.generateReport("charges");
            displayManager.displayReport(listBox1);
        }
    }
}
