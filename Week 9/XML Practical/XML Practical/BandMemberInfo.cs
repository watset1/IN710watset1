using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_Practical
{
    public class BandMemberInfo : IInformation
    {
        String memberName;
        String instruments;
        String role;
        String errorMessage;

        public BandMemberInfo()
        {
            memberName = "";
            instruments = "";
            role = "";
            errorMessage = "Information not supplied";
        }

        public String[] getInfo(XElement bandMember)
        {
            memberName = getMemberName(bandMember);
            instruments = getInstruments(bandMember);
            if (bandMember.Element("Role") != null)
                role = bandMember.Element("Role").Value;
            else
                role = errorMessage;
            String[] infoArray = { memberName, instruments, role };

            return infoArray;
        }

        private String getMemberName(XElement bandMember)
        {
            String firstName = bandMember.Element("First_Name").Value;
            String lastName = bandMember.Element("Last_Name").Value;

            return firstName + " " + lastName;
        }

        private String getInstruments(XElement bandMember)
        {
            String instrumentString = "";
            foreach (XElement instrument in bandMember.Elements("Instruments"))
                if (bandMember.Element("Instruments").Element("Instrument") != null)
                    instrumentString += bandMember.Element("Instruments").Element("Instrument").Value + " ";
                else
                    instrumentString = errorMessage;

            return instrumentString;
        }
    }
}
