using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolidayApplication.Models
{
    public enum EHolidayType { BOXING_DAY, QUEENS_BIRTHDAY, HALLOWEEN }

    public class Holiday
    {
        public String Name { get; set; }
        public DateTime Date { get; set; }
        public int DaysTo { get; set; }
        public String ImageFile { get; set; }
    }
}