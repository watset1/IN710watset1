using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Builder
{
    public class MachineSpecPrinter
    {
        private IMachineMaker machineMaker;
        private ListBox displayBox;

        public MachineSpecPrinter(IMachineMaker machineMaker, ListBox displayBox)
        {
            this.machineMaker = machineMaker;
            this.displayBox = displayBox;
        }

        public void printSpec()
        {
            Cpu currCpu = machineMaker.makeCpu();
            Ram currRam = machineMaker.makeRam();
            Gpu currGpu = machineMaker.makeGpu();
            Motherboard currMb = machineMaker.makeMotherBoard();

            double totalPrice = currCpu.Price + currRam.Price + currGpu.Price + currMb.Price;

            displayBox.Items.Clear();
            displayBox.Items.Add("Price\tComponent");
            displayBox.Items.Add("--------------------------------");
            displayBox.Items.Add("$" + currCpu.ToString());
            displayBox.Items.Add("$" + currRam.ToString());
            displayBox.Items.Add("$" + currGpu.ToString());
            displayBox.Items.Add("$" + currMb.ToString());
            displayBox.Items.Add("--------------------------------");
            displayBox.Items.Add("Total Price: $" + totalPrice.ToString());
        }
    }
}
