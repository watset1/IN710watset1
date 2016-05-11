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
        const int MAX_ASSIGNMENTS = 100;
        const int TWOWEEKS = 14;
        const int DATEFIELD = 2;

        SqlConnection bitdevConnection;
        SqlDataReader queryReader;
        String queryString;
        int fieldCount;
        List<String[]> queryResults;
        List<String> paperNames;


        public DatabaseManager()
        {
            connectToDatabase();
            paperNames = new List<string>();
            getPaperNames();
        }

        private void connectToDatabase()
        {
            bitdevConnection = new SqlConnection();
            bitdevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" + "Initial Catalog = IN710_201601_WATSET1;" + "User ID = watset1;" + "Password = EWa_BF28;";
        }

        private void getPaperNames()
        {
            queryString = "SELECT tblPaper.name as Name FROM dbo.tblPaper;";
            SqlCommand command = new SqlCommand(queryString, bitdevConnection);
            bitdevConnection.Open();
            queryReader = command.ExecuteReader();
            while (queryReader.Read())
                paperNames.Add(queryReader["name"].ToString());
            bitdevConnection.Close();

        }

        public void GetPaperTutorInfo(DataGridView dgv)
        {
            queryString = "SELECT name as Name, firstName as Tutor, email as 'Email Address' FROM dbo.tblPaper JOIN dbo.tblTutor ON tblPaper.tutorID = tblTutor.tutorID";
            getQueryResults(dgv);
            displayPapers(dgv);
        }

        public void GetNextTwoWeeksAssignments(DataGridView dgv)
        {
            queryString = "SELECT tblAssignment.name as Assignment, tblPaper.name as Paper, tblAssignment.dueDate as 'Due Date' FROM dbo.tblAssignment JOIN dbo.tblPaper ON tblAssignment.paperID = tblPaper.paperID";
            getQueryResults(dgv);
            displayAssignments(dgv);
        }

        public void GetAverageMark(DataGridView dgv)
        {
            queryString = "SELECT tblPaper.name as Paper, mark as 'Average Mark' FROM dbo.tblPaper JOIN dbo.tblAssignment ON tblPaper.paperID = tblAssignment.paperID;";
            getQueryResults(dgv);
            displayAverageMarks(dgv);
        }

        private void getQueryResults(DataGridView dgv)
        {
            SqlCommand command = new SqlCommand(queryString, bitdevConnection);
            bitdevConnection.Open();
            queryReader = command.ExecuteReader();
            fieldCount = queryReader.FieldCount;
            createColumns(queryReader, dgv, fieldCount);
            queryResults = new List<string[]>();
        }

        private void displayPapers(DataGridView dgv)
        {
            while (queryReader.Read())
            {
                String[] row = new String[fieldCount];
                for (int i = 0; i < fieldCount; i++)
                {
                    row[i] = queryReader.GetValue(i).ToString();
                }
                dgv.Rows.Add(row);
            }
            bitdevConnection.Close();
        }

        private void displayAssignments(DataGridView dgv)
        {
            while (queryReader.Read())
            {
                DateTime today = DateTime.Now;
                DateTime dueDate = DateTime.Parse(queryReader["Due Date"].ToString());
                String[] row = new String[fieldCount];
                if ((dueDate - DateTime.Now).TotalDays < TWOWEEKS)
                {
                    for (int i = 0; i < fieldCount; i++)
                        row[i] = queryReader.GetValue(i).ToString();
                    dgv.Rows.Add(row);
                }
            }
            bitdevConnection.Close();
        }

        private void displayAverageMarks(DataGridView dgv)
        {
            int[] totalAssignments = new int[MAX_ASSIGNMENTS];
            int[] paperTotalMarks = new int[paperNames.Count()];
            while (queryReader.Read())
            {
                for (int i = 0; i < paperNames.Count(); i++)
                {
                    if (queryReader["Paper"].Equals(paperNames[i]))
                    {
                        if (queryReader["Average Mark"] != DBNull.Value)
                        {
                            totalAssignments[i] += 1;
                            paperTotalMarks[i] += Convert.ToInt16(queryReader["Average Mark"]);
                        }
                    }
                }			                   
            }
            for (int i = 0; i < paperNames.Count(); i++)
            {
                int averageMark = 0;
                String paperName = paperNames[i];
                if(paperTotalMarks[i] > 0)
                    averageMark = paperTotalMarks[i] / totalAssignments[i];
                dgv.Rows.Add(paperName, averageMark);
            }
            bitdevConnection.Close();
        }

        private void createColumns(SqlDataReader queryReader, DataGridView dgv, int fieldCount)
        {
            String column = "";
            for (int i = 0; i < fieldCount; i++)
            {
                column = queryReader.GetName(i);
                dgv.Columns.Add(column, column);
            }
        }
    }
}
