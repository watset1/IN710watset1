using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XML_Practical
{
    public partial class Form1 : Form
    {
        public delegate void DisplayMethod(XElement gig, GigInfo currentGig);

        XDocument gigDoc;
        DataGridViewRowCollection gridRow;
        DataGridViewRowCollection gridRow2;

        public Form1()
        {
            InitializeComponent();
            gigDoc = XDocument.Load("pubsAndClubs.xml");
            addGig();
            gridRow = dataGridView1.Rows;
            gridRow2 = dataGridView2.Rows;
            populateGenreComboBoxes();
        }

        private void displayAllGigs(XElement gig, GigInfo currentGig)
        {
            gridRow.Add(currentGig.getInfo(gig));
        }

        //After implementing a button that searched for only "Hard Rock" I modified the code to search by genre
        private void filterByGenre(XElement gig, GigInfo currentGig)
        {
            if (gig.Element("Band").Element("Genre").Value == comboBox1.Text)
                gridRow.Add(currentGig.getInfo(gig));
        }

        private void displayByCurrentMonth(XElement gig, GigInfo currentGig)
        {
            String currentMonth = DateTime.Now.ToString("MM");
            if (gig.Element("Date").Attribute("month").Value == currentMonth)
                gridRow.Add(currentGig.getInfo(gig));
        }

        private void gigDisplayMethod(DisplayMethod displayMethod)
        {
            dataGridView1.Rows.Clear();
            foreach (XElement gig in gigDoc.Element("Event_Guide").Elements("Gig"))
            {
                GigInfo currentGig = new GigInfo();
                displayMethod(gig, currentGig);
            }
        }

        //As with the filterByGenre() method after initially having only Alabama Shakes members displayed, I then gave the dropdown box option
        private void bandInfoDisplay()
        {           
            dataGridView2.Rows.Clear();
            foreach (XElement gig in gigDoc.Element("Event_Guide").Elements("Gig")) 
            {
                if (gig.Element("Band").Element("Name").Value == comboBox2.Text)
                {

                    foreach (XElement bandMember in gig.Element("Band").Elements("Band_Members").Elements("Member"))
                    {
                        BandMemberInfo currentBandMember = new BandMemberInfo();
                        gridRow2.Add(currentBandMember.getInfo(bandMember));
                    }
                }          
            }
        }

        private void populateGenreComboBoxes()
        {
            foreach (XElement gig in gigDoc.Element("Event_Guide").Elements("Gig"))
            {
                comboBox1.Items.Add(gig.Element("Band").Element("Genre").Value);
                comboBox2.Items.Add(gig.Element("Band").Element("Name").Value);
            }
                
        }

        private void addGig()
        {
            XElement newGig =  new XElement("Gig", 
                                 new XElement("Venue", "Otago Polytechnic, D-Block"), 
                                 new XElement("Date", 
                                     new XAttribute("day", "03"), new XAttribute("month", "05"), new XAttribute("year", "2016")), 
                                 new XElement("Time","1:00pm"), 
                                 new XElement("Band", 
                                     new XElement("Name", "Glade"), 
                                     new XElement("Genre","Party Rock"), 
                                     new XElement("Band_Members", 
                                         new XElement("Member", 
                                             new XElement("First_Name", "Gowtham"), 
                                             new XElement("Last_Name", "Reddy"), 
                                             new XElement("Role", "Vocals"), 
                                             new XElement("Instruments", 
                                                 new XElement("Instrument", "Microphone"))),
                                         new XElement("Member", 
                                             new XElement("First_Name", "Dan"), 
                                             new XElement("Last_Name", "Williamson"), 
                                             new XElement("Role", "Bassist"), 
                                             new XElement("Instruments", 
                                                 new XElement("Instrument", "Bass Guitar"))),
                                         new XElement("Member", 
                                             new XElement("First_Name", "Lewis"), 
                                             new XElement("Last_Name", "Gearing"), 
                                             new XElement("Role", "Lead Guitarist"),
                                             new XElement("Instruments",
                                                 new XElement("Instrument", "Electric Guitar"))),
                                         new XElement("Member", 
                                             new XElement("First_Name", "Emerson"),
                                             new XElement("Last_Name", "Watson"), 
                                             new XElement("Role", "Drummer"), 
                                             new XElement("Instruments", 
                                                 new XElement("Instrument", "Drums"))),
                                         new XElement("Member", 
                                             new XElement("First_Name", "Aidan Ezra"), 
                                             new XElement("Last_Name", "Smith"), 
                                             new XElement("Role", "Groupie"), 
                                             new XElement("Instruments", 
                                                 new XElement("Instrument", "Maracas"))))));
            gigDoc.Element("Event_Guide").Add(newGig);
        }

        private void btnDisplayAllGigs_Click(object sender, EventArgs e)
        {
            gigDisplayMethod(displayAllGigs);
        }

        private void btnGenreFilter_Click(object sender, EventArgs e)
        {
            gigDisplayMethod(filterByGenre);
        }

        private void btnMonthGigs_Click(object sender, EventArgs e)
        {
            gigDisplayMethod(displayByCurrentMonth);
        }

        private void btnBandInfo_Click(object sender, EventArgs e)
        {
            bandInfoDisplay();
        }
    }
}
