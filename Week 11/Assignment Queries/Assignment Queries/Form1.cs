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

        public Form1()
        {
            InitializeComponent();
            dbManager = new DatabaseManager();
        }

        private void btnPaperList_Click(object sender, EventArgs e)
        {
            clearGrid();
            dbManager.GetPaperTutorInfo(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearGrid();
            dbManager.GetNextTwoWeeksAssignments(dataGridView1);
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            clearGrid();
            dbManager.GetAverageMark(dataGridView1);
        }

        private void clearGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }
    }
}
