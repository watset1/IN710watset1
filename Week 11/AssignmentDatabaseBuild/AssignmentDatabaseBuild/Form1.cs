using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentDatabaseBuild
{
    public partial class Form1 : Form
    {
        DatabaseManager dbManager;

        public Form1()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void btnCreateTables_Click(object sender, EventArgs e)
        {
            dbManager.CreateAllTables();
            btnCreateTables.Enabled = false;
            btnSeedData.Enabled = true;
        }

        private void btnSeedData_Click(object sender, EventArgs e)
        {
            dbManager.PopulateTables();
            this.Close();
        }
    }
}
