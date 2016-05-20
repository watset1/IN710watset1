using DogSelector.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DogSelector.Controllers
{
    public class DogSelectController : Controller
    {
        //
        // GET: /DogSelector/

        [HttpGet]
        public ActionResult DogSelector()
        {
            return View("DogSelector");
        }

        [HttpPost]
        public ActionResult DogSelector(Dog dogQualities)
        {
            Dog chosenDog = null;
            chosenDog = chooseDog(dogQualities);           
            if (chosenDog != null)
                return View("DogRecommendation", chosenDog);
            else
                return View("NoSuitableDog");
        }

        private Dog chooseDog(Dog dogQualities)
        {
            Dog appropriateDog = null;
            DogDatabase database = new DogDatabase();
            foreach (Dog currentDog in database.database)
            {
                if (checkChildren(dogQualities.GoodWithChildren, currentDog.GoodWithChildren))
                    if (checkDrools(dogQualities.Drools, currentDog.Drools))
                        if (dogQualities.Coatlength.Equals(currentDog.Coatlength))
                            if (checkScalers(dogQualities.ActivityLevel, currentDog.ActivityLevel))
                                if (checkScalers(dogQualities.SheddingLevel, currentDog.SheddingLevel))
                                    if (checkScalers(dogQualities.GroomingLevel, currentDog.GroomingLevel))
                                        if (checkScalers(dogQualities.IntelligenceLevel, currentDog.IntelligenceLevel))
                                            if (checkSize(dogQualities.Size, currentDog.Size))
                                                appropriateDog = currentDog;
            }
            
            return appropriateDog;
        }

        private bool checkChildren(bool dogQualitiesBool, bool currentDogBool)
        {
            if (dogQualitiesBool)
                if (currentDogBool.Equals(true))
                    return true;
                else
                    return false;
            else
                return true;
        }

        private bool checkDrools(bool dogQualitiesBool, bool currentDogBool)
        {
            if (dogQualitiesBool)
                if (currentDogBool.Equals(true))
                    return true;
                else
                    return false;
            else
                return true;
        }

        private bool checkScalers(EScale dogQualitiesEScaleValue, EScale currentDogEScaleValue)
        {
            if (dogQualitiesEScaleValue != EScale.NoPreference)
                if (currentDogEScaleValue.Equals(dogQualitiesEScaleValue))
                    return true;
                else
                    return false;
            else
                return true;
        }

        private bool checkSize(ESize dogQualitiesESizeValue, ESize currentDogESizeValue)
        {
            if (currentDogESizeValue.Equals(dogQualitiesESizeValue))
                return true;
            else
                return false;
        }
	}
}