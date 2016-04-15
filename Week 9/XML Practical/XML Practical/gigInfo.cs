using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_Practical
{
    public class GigInfo : IInformation
    {
        String bandName;
        String genre;
        String venue;
        String date;
        String time;

        public GigInfo()
        {
            bandName = "";
            genre = "";
            venue = "";
            date = "";
            time = "";
        }

        public String[] getInfo(XElement gig)
        {
            bandName = gig.Element("Band").Element("Name").Value;
            genre = gig.Element("Band").Element("Genre").Value;
            venue = gig.Element("Venue").Value;
            date = formatDate(gig);
            time = gig.Element("Time").Value;
            String[] infoArray = { bandName, genre, venue, date, time };

            return infoArray;
        }

        private String formatDate(XElement gig)
        {
            String day = gig.Element("Date").Attribute("day").Value;
            String month = gig.Element("Date").Attribute("month").Value;
            String year = gig.Element("Date").Attribute("year").Value;

            return day + '/' + month + '/' + year;
        }
    }
}
