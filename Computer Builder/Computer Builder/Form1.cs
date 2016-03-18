using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IMachineMaker currMachineMaker;

        private void btnPrintSpec_Click(object sender, EventArgs e)
        {
            if (rdGaming.Checked)
                currMachineMaker = new GamingMachineMaker();
            else if (rdBusiness.Checked)
                currMachineMaker = new BusinessMachineMaker();
            else if(rdMultimedia.Checked)
                currMachineMaker = new MultimediaMachineMaker();

            MachineSpecPrinter currSpecPrinter = new MachineSpecPrinter(currMachineMaker, listBox1);
            currSpecPrinter.printSpec();
        }
    }
}
