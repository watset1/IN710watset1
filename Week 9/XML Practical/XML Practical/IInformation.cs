using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XML_Practical
{
    public interface IInformation
    {
        String[] getInfo(XElement element);
    }
}
