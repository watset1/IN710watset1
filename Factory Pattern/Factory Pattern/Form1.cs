using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Pattern
{
    public partial class Form1 : Form
    {
        AnimalManager animalManager;
        Graphics canvas;

        public Form1()
        {
            InitializeComponent();
            canvas = this.CreateGraphics();
            animalManager = new AnimalManager(listBox1, canvas);
        }

        private void northAmerica_Click(object sender, EventArgs e)
        {
            ClearDisplay();
            animalManager.NorthAmericanSim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearDisplay();
            animalManager.AustralianSim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearDisplay();
            animalManager.AfricanSim();
        }

        public void ClearDisplay()
        {
            listBox1.Items.Clear();
        }


    }
}
