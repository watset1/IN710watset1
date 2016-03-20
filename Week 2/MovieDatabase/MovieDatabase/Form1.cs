using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabase
{
    public partial class Form1 : Form
    {
        private SortedDictionary<int, Movie> movieTable;
        private Movie Movie { get; set;}
        private Movie SelectedMovie { get; set; }
        private String Feedback { get; set; }

        public Form1()
        {
            InitializeComponent();
            movieTable = new SortedDictionary<int, Movie>();
            CreateInitialMovieEntries();
        }

        //Seeds the database with records
        public void CreateInitialMovieEntries()
        {
            List<Movie> seedList = new List<Movie>();

            Movie movie1 = new Movie(1961, "West SideStory", "Jerome Robbins");
            Movie movie2 = new Movie(1972, "The Godfather", "Francis Ford Coppola");
            Movie movie3 = new Movie(1984, "Amadeus", "Milos Forman");
            Movie movie4 = new Movie(2007, "No Country for Old Men", "Ethan & Joel Coen");

            seedList.Add(movie1);
            seedList.Add(movie2);
            seedList.Add(movie3);
            seedList.Add(movie4);

            foreach (Movie movie in seedList)
            {
                AddMovieToDatabase(movie);
            }
        }

        //Adds movie to dictionary
        public void AddMovieToDatabase(Movie movie)
        {
            if (movieTable.ContainsKey(movie.Year))
            {               
                Feedback = "A movie for that year already exists in the database";
            }
            else
            {
                movieTable.Add(movie.Year, movie);
                Feedback = movie.Title + ", " + movie.Year + ", has been successfully added to the database.";
            }
        }

        //Creates movie object from textbox entries
        public Movie CreateMovieRecord()
        {
            int key = Convert.ToInt16(txtAddYear.Text);
            String addTitle = txtAddTitle.Text;
            String addDirector = txtAddDirector.Text;

            Movie = new Movie(key, addTitle, addDirector);
            return Movie;
        }

        //Selects a specific movie record from the dictionary
        public Movie SelectMovie(TextBox textBox)
        {
            int key = Convert.ToInt16(textBox.Text);
            SelectedMovie = movieTable[key];
            return SelectedMovie;
        }

        //Clears the text in all textboxes and listboxes
        private void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else if (c is ListBox)
                    ((ListBox)c).Items.Clear();
                else
                    ClearAllText(c);
            }
        }

        //Shows message of stored feedback
        public void DisplayFeedback(String feedback)
        {
            MessageBox.Show(feedback);
        }

        //Textbox error checking
        public void ErrorChecking(TextBox textBox)
        {
            int parsedValue;
            if (!int.TryParse(textBox.Text, out parsedValue))
            {
                Feedback = "The year field can only contain numbers and cannot be left empty";
            }
            else
            {
                if (movieTable.ContainsKey(Convert.ToInt16(textBox.Text)))
                {
                    if (textBox == txtDeleteYear)
                        DeleteRecord(textBox);
                    else if (textBox == txtSearchYear)
                        DisplayRecord(textBox);
                    else if (textBox == txtAddYear)
                        Feedback = "A movie with that year already exists in the database";
                }
                else
                {
                    if (textBox == txtAddYear)
                    {
                        AddRecord(textBox);
                    }
                    else
                    {
                        Feedback = "Could not find movie from that year in database";
                    }
                }
            }
            DisplayFeedback(Feedback);
        }
        
        public void AddRecord(TextBox textBox)
        {
            CreateMovieRecord();
            AddMovieToDatabase(Movie);
            ClearAllText(this);
        }

        public void DeleteRecord(TextBox textBox)
        {
            SelectMovie(textBox);
            Feedback = SelectedMovie.Title + " has been deleted from the database.";
            movieTable.Remove(Convert.ToInt16(SelectedMovie.Year));
            ClearAllText(this);
        }

        public void DisplayRecord(TextBox textBox)
        {
            SelectMovie(textBox);
            Feedback = "Match Found";
            ClearAllText(this);
            listBox1.Items.Add(SelectedMovie.ToString());
        }

        public void DisplayAllRecords()
        {
            foreach (KeyValuePair<int, Movie> currentMovie in movieTable)
            {
                listBox1.Items.Add("-------------------------------------------------------------------------");
                listBox1.Items.Add(currentMovie.Key.ToString());
                listBox1.Items.Add(currentMovie.Value.ToString());
            }
            listBox1.Items.Add("-------------------------------------------------------------------------");
        }

        private void addMovie_Click(object sender, EventArgs e)
        {
            if (txtAddYear.Text == "" || txtAddTitle.Text == "" || txtAddDirector.Text == "")
            {
                Feedback = "Missing one or more fields";
                DisplayFeedback(Feedback);
            }
            else
            {
                ErrorChecking(txtAddYear);
            }
        }

        private void deleteMovie_Click(object sender, EventArgs e)
        {
            ErrorChecking(txtDeleteYear);
        }

        private void searchDatabase_Click(object sender, EventArgs e)
        {
            ErrorChecking(txtSearchYear);
        }

        private void printAllRecords_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
            DisplayAllRecords();
        }

        
    }
}
