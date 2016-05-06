using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightningMonitor
{
    public class DatabaseManager
    {
        LightningStrikesDataContext db;

        public DatabaseManager()
        {
            db = new LightningStrikesDataContext();
        }

        public double ComputeAverageIntensity()
        {
            var allStrikes = from strike in db.tblStrikes
                             select strike.strikeIntensity;

            return allStrikes.Average();
        }

        public void GetThreeLargestFires(ListBox listBox)
        {
            var allFires = from fire in db.tblFires
                           orderby fire.fireArea descending
                           select fire;

            var threeLargest = allFires.Take(3);

            listBox.Items.Add("Fire ID\tDate\t\t\tLatitude\tLongitude    Area");
            foreach (var fire in threeLargest)
                listBox.Items.Add(fire.fireID + "\t" + fire.fireDate.ToString() + "\t" + fire.fireLatitude + "\t" + fire.fireLongitude + "\t    " + fire.fireArea);
        }

        public void GetPictureLatLong(ListBox listBox)
        {
            var allPictures = from picture in db.tblPictures
                              join strike in db.tblStrikes on picture.strikeID equals strike.strikeID
                              select picture;

            listBox.Items.Add("Picture ID\tLatitude\tLongitude\tFilename");
            foreach (var picture in allPictures)
                listBox.Items.Add(picture.pictureID + "\t\t" + picture.tblStrike.strikeLatitude + "\t" + picture.tblStrike.strikeLongitude + "\t\t" + picture.pictureFileName);
        }

        public void GetStrikesCausingFires(ListBox listBox)
        {
            var allStrikes = from strike in db.tblStrikes
                             join fire in db.tblFires on strike.strikeDate equals fire.fireDate
                             where strike.strikeLatitude.Equals(fire.fireLatitude) && strike.strikeLongitude.Equals(fire.fireLongitude)
                             select fire;

            listBox.Items.Add("Fire ID\tDate\t\t\tLatitude\tLongitude    Area");
            foreach(var fire in allStrikes)
                listBox.Items.Add(fire.fireID + "\t" + fire.fireDate.ToString() + "\t" + fire.fireLatitude + "\t" + fire.fireLongitude + "\t    " + fire.fireArea);
        }
    }
}
