using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDatabaseBuild
{
    public class DatabaseManager
    {
        SqlConnection bitdevConnection;
        String insertString;

        public DatabaseManager()
        {
            connectToDatabase();           
        }

        private void dropTables()
        {           
            String dropAssignmentTbl = "IF OBJECT_ID('tblAssignment') IS NOT NULL DROP TABLE tblAssignment";
            String dropPaperTbl = "IF OBJECT_ID('tblPaper') IS NOT NULL DROP TABLE tblPaper";
            String dropTutorTbl = "IF OBJECT_ID('tblTutor') IS NOT NULL DROP TABLE tblTutor";
                        
            runNonQuery(dropAssignmentTbl);
            runNonQuery(dropPaperTbl);
            runNonQuery(dropTutorTbl);
        }

        private void connectToDatabase()
        {
            bitdevConnection = new SqlConnection();
            bitdevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" + "Initial Catalog = IN710_201601_WATSET1;" + "User ID = watset1;" + "Password = EWa_BF28;";
        }

        public void CreateAllTables()
        {
            dropTables();

            String tutorQuery = "CREATE TABLE tblTutor ( tutorID int IDENTITY, firstName    VARCHAR(15) NOT NULL, lastName VARCHAR(15)  NOT NULL, email VARCHAR(30) NOT NULL, PRIMARY KEY(tutorID));";
            String paperQuery = "CREATE TABLE tblPaper ( paperID int IDENTITY, name VARCHAR(30) NOT NULL, tutorID   int NOT NULL, PRIMARY KEY(paperID), FOREIGN KEY(tutorID) REFERENCES tblTutor(tutorID));";
            String assignmentQuery = "CREATE TABLE tblAssignment ( assignmentID int IDENTITY, paperID int NOT NULL, name VARCHAR(25) NOT NULL, dueDate date NOT NULL, mark numeric(3) NULL, PRIMARY KEY(assignmentID), FOREIGN KEY(paperID) REFERENCES tblPaper(paperID));";

            runNonQuery(tutorQuery);
            runNonQuery(paperQuery);
            runNonQuery(assignmentQuery);
        }

        private void runNonQuery(String queryString)
        {
            SqlCommand cmdQuery = new SqlCommand(queryString, bitdevConnection);
            bitdevConnection.Open();
            cmdQuery.ExecuteNonQuery();
            bitdevConnection.Close();
        }

        private void insertTutor(String firstName, String lastName, String email)
        {
            insertString = "INSERT INTO tblTutor VALUES('" + firstName + "', '" + lastName + "', '" + email + "')";
            runNonQuery(insertString);
        }

        private void insertPaper(String name, int tutorID)
        {
            insertString = "INSERT INTO tblPaper VALUES('" + name + "', " + tutorID + ")";
            runNonQuery(insertString);
        }

        private void insertAssignment(int paperID, String name, String dueDate, int mark, bool marked)
        {
            if(marked)
                insertString = "INSERT INTO tblAssignment VALUES(" + paperID + ", '" + name + "', '" + dueDate + "', " + mark + ")";
            else
                insertString = "INSERT INTO tblAssignment VALUES(" + paperID + ", '" + name + "', '" + dueDate + "', null)";
            runNonQuery(insertString);
        }

        private void populateTblTutor()
        {
            insertTutor("Elvis", "Admonica", "elvisa@op.ac.nz");
            insertTutor("Krissi", "Wood", "krissi.wood@op.ac.nz");
            insertTutor("Patricia", "Haden", "patricia.haden@op.ac.nz");
            insertTutor("Tom", "Clark", "tom.clark@op.ac.nz");
        }

        private void populateTblPaper()
        {
            insertPaper("Software Engineering", 1);
            insertPaper("Databases 2", 2);
            insertPaper("OOSD", 3);
            insertPaper("Security", 4);
        }

        private void populateTblAssignment()
        {
            insertAssignment(1, "Project", "2016-5-12", 91, true);
            insertAssignment(1, "Essay", "2016-5-26", 0, false);
            insertAssignment(1, "Ruby Presentation", "2016-6-25", 0, false);
            insertAssignment(2, "SQL Worksheet", "2016-4-08", 100, true);
            insertAssignment(2, "Design Assignment", "2016-4-15", 92, true);
            insertAssignment(2, "XML Worksheet", "2016-5-27", 0, false);
            insertAssignment(2, "Build Assignment", "2016-6-03", 0, false);
            insertAssignment(2, "Exam", "2016-6-17", 0, false);
            insertAssignment(3, "Grey-Scott Simulator", "2016-5-02", 80, true);
            insertAssignment(3, "This Lab", "2016-5-13", 0, false);
            insertAssignment(3, "ASP.NET Assignment", "2016-6-03", 0, false);
            insertAssignment(3, "Exam", "2016-6-17", 0, false);
            insertAssignment(4, "Attack Assignment", "2016-5-24", 0, false);
            insertAssignment(4, "Class Labs", "2016-6-10", 0, false);
            insertAssignment(4, "Exam", "2016-6-16", 0, false);
        }

        public void PopulateTables()
        {
            populateTblTutor();
            populateTblPaper();
            populateTblAssignment();
        }
    }
}
