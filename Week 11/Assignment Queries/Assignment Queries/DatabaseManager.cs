using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_Queries
{
    public class DatabaseManager
    {
        public delegate void QueryDelegate(DataGridViewRowCollection gridRow);        

        const int TWOWEEKS = 14;

        QueryDelegate query;
        SqlConnection bitdevConnection;
        SqlDataReader queryReader;
        String queryString;
        int[] totalMarks;
        int averageMark;
        int queryIteration;
        List<String> parameters;

        public DatabaseManager()
        {
            connectToDatabase();
        }

        private void connectToDatabase()
        {
            bitdevConnection = new SqlConnection();
            bitdevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" + "Initial Catalog = IN710_201601_WATSET1;" + "User ID = watset1;" + "Password = EWa_BF28;";
        }

        public void GetPaperTutorInfo(DataGridView dgv, DataGridViewRowCollection gridRow)
        {
            query = new QueryDelegate(paperQuery);
            queryString = "SELECT name as Name, firstName as Tutor, email as 'Email Address' FROM dbo.tblPaper JOIN dbo.tblTutor ON tblPaper.tutorID = tblTutor.tutorID";
            parameters = new List<string>{
                "Name",
                "Tutor",
                "Email Address"
            };
            readQuery(dgv, query);
        }

        public void GetNextTwoWeeksAssignments(DataGridView dgv, DataGridViewRowCollection gridRow)
        {
            query = new QueryDelegate(dueDateQuery);
            queryString = "SELECT tblAssignment.name as Assignment, tblPaper.name as Paper, tblAssignment.dueDate as 'Due Date' FROM dbo.tblAssignment JOIN dbo.tblPaper ON tblAssignment.paperID = tblPaper.paperID";
            parameters = new List<string>{
                "Assignment",
                "Paper",
                "Due Date"
            };
            readQuery(dgv, query);
        }

        public void GetAverageMark(DataGridView dgv, DataGridViewRowCollection gridRow)
        {
            
        }

        private void readQuery(DataGridView dgv, QueryDelegate query)
        {
            DataGridViewRowCollection gridRow = dgv.Rows;
            SqlCommand command = new SqlCommand(queryString, bitdevConnection);
            bitdevConnection.Open();
            queryReader = command.ExecuteReader();
            for (int i = 0; i < parameters.Count(); i++)
                dgv.Columns.Add(("Column" + i.ToString()), parameters[i]);
            while(queryReader.Read())
            {
                query(gridRow);                           
            }
            bitdevConnection.Close();
        }

        private void dueDateQuery(DataGridViewRowCollection gridRow)
        {
            DateTime today = DateTime.Now;
            DateTime dueDate = DateTime.Parse(queryReader["Due Date"].ToString());
            if ((dueDate - DateTime.Now).TotalDays < TWOWEEKS)
            {
                String assignment = queryReader["Assignment"].ToString();
                String paper = queryReader["Paper"].ToString();
                String due = queryReader["Due Date"].ToString();
                gridRow.Add(assignment, paper, due);
            }    
        }

        private void paperQuery(DataGridViewRowCollection gridRow)
        {
            String name = queryReader["Name"].ToString();
            String tutor = queryReader["Tutor"].ToString();
            String email = queryReader["Email Address"].ToString();
            gridRow.Add(name, tutor, email);
        }

        private void markQuery(DataGridViewRowCollection gridRow)
        {
            
        }
    }
}
