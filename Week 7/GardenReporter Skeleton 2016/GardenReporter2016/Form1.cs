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
        ReportManager reportManager;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportManager = new ReportManager();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            reportManager.reportMaker = new AreaReportMaker();
            updateDisplay();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            reportManager.reportMaker = new AccountBalanceReportMaker();
            updateDisplay();
        }

        private void btnCharges_Click(object sender, EventArgs e)
        {
            reportManager.reportMaker = new ChargesReportMaker();
            updateDisplay();
        }

        public void updateDisplay()
        {
            reportManager.generateReport(reportManager.reportMaker);
            reportManager.displayReport(listBox1);
        }

        
    }
}
