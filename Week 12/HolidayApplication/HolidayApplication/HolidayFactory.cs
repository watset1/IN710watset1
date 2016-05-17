using HolidayApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolidayApplication
{
    public class HolidayFactory
    {
        public HolidayFactory() { }

        public Holiday CreateHoliday(EHolidayType holidayType)
        {
            Holiday holiday = new Holiday();

            switch(holidayType)
            {
                case EHolidayType.BOXING_DAY:
                    holiday.Name = "Boxing Day";
                    holiday.Date = DateTime.Parse("2016-12-26");
                    holiday.ImageFile = "boxingDay.jpg";
                    break;

                case EHolidayType.QUEENS_BIRTHDAY:
                    holiday.Name = "Queen's Birthday";
                    holiday.Date = DateTime.Parse("2016-6-06");
                    holiday.ImageFile = "queensBirthday.jpg";
                    break;

                case EHolidayType.HALLOWEEN:
                    holiday.Name = "Halloween";
                    holiday.Date = DateTime.Parse("2016-10-31");
                    holiday.ImageFile = "halloween.jpg";
                    break;
            }

            return holiday;
        }
    }
}