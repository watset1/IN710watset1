using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixNMatch
{
    public partial class Form1 : Form
    {
        CharacterPrinter printer;
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
                showPictureBoxes();
                printer = new CharacterPrinter();
                printer.printHead(pictureBox1, comboBox1.Text);
                printer.printBody(pictureBox2, comboBox2.Text);
                printer.printLegs(pictureBox3, comboBox3.Text);
            }
            else
            {
                String errorMessage = "* Not all fields have been chosen.";
                lblError.Text = errorMessage;
            }
        }

        public void displayOptions()
        {
            CharacterListHolder characterList = new CharacterListHolder();
            List<String> comboBoxList = characterList.populateList();
            foreach (String  option in comboBoxList)
	        {
                comboBox1.Items.Add(option);
		        comboBox2.Items.Add(option);
                comboBox3.Items.Add(option);
	        }
        }

        public void showPictureBoxes()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
        }
    }
}
