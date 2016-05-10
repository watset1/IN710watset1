using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Queries
{
    public partial class Form1 : Form
    {
        DatabaseManager dbManager;
        DataGridViewRowCollection gridRow;

        public Form1()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
            gridRow = dataGridView1.Rows;
        }

        private void btnPaperList_Click(object sender, EventArgs e)
        {
            clearGrid();
            dbManager.GetPaperTutorInfo(dataGridView1, gridRow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearGrid();
            dbManager.GetNextTwoWeeksAssignments(dataGridView1, gridRow);
        }

        private void clearGrid()
        {            
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }
    }
}
