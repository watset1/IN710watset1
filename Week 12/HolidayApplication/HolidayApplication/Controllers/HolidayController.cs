using HolidayApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HolidayApplication.Controllers
{
    public class HolidayController : Controller
    {
        //
        // GET: /Holiday/
        const int HOLIDAYS = 3;

        HolidayFactory holidayFactory;
        Holiday holiday;
        Random random;

        public ActionResult Index()
        {
            holidayFactory = new HolidayFactory();
            random = new Random();
            int rand = random.Next(HOLIDAYS);

            switch(rand)
            {
                case (int)EHolidayType.BOXING_DAY:
                    holiday = holidayFactory.CreateHoliday(EHolidayType.BOXING_DAY);
                    break;
                    
                case (int)EHolidayType.HALLOWEEN:
                    holiday = holidayFactory.CreateHoliday(EHolidayType.HALLOWEEN);
                    break;

                case (int)EHolidayType.QUEENS_BIRTHDAY:
                    holiday = holidayFactory.CreateHoliday(EHolidayType.QUEENS_BIRTHDAY);
                    break;
            }
            calculateDaysTo(holiday);
            return View(holiday);
        }

        private void calculateDaysTo(Holiday holiday)
        {
            int dayResult = holiday.Date.DayOfYear - DateTime.Now.DayOfYear;
            if (dayResult < 0)
                dayResult += 365;
            holiday.DaysTo = dayResult;
        }
	}
}