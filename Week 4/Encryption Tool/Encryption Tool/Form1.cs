using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption_Tool
{
    public partial class Form1 : Form
    {
        public Parser mainParser;

        public Form1()
        {
            InitializeComponent();
            mainParser = new Parser();     
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (rdRot13.Checked)
                mainParser.encryptionMachine = new Rot13();
            else
                mainParser.encryptionMachine = new Reverse();
            String plainText = txtInput.Text;
            String cypher = mainParser.Encrypt(plainText);
            txtOutput.Text = cypher;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (rdRot13.Checked)
                mainParser.encryptionMachine = new Rot13();
            else
                mainParser.encryptionMachine = new Reverse();
            String plainText = txtInput.Text;
            String cypher = mainParser.Encrypt(plainText);
            txtOutput.Text = cypher;
        }
    }
}
