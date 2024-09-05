using NUnit.Framework;
using OpenQA.Selenium;
using CompetitionMars.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionMars.Pages
{
    public class AddEducationPage
    {
        LocateAndClickAddNew locateCickObj = new LocateAndClickAddNew();
        LocateAndEnterDegreeTextbox degreeTexboxObj= new LocateAndEnterDegreeTextbox();
        LocateAndEnterUniversityTextbox universityTextboxObj = new LocateAndEnterUniversityTextbox();
        CountryOptions countryOptionsObj= new CountryOptions();
        TitleOptions titleOptionObj = new TitleOptions();
        YearOptions yearObj= new YearOptions();
        LocateClickAddButton clickAddButtonObj = new LocateClickAddButton();

       
        //Locate Add new button and click
        public void AddEducation(IWebDriver driver)
        {
            locateCickObj.LocateClickAddNew(driver);
        }

        //Add 4 languages including speacial character,numbers,long characters at different levels
        public void InputEducation(IWebDriver driver, string university, string degree, string country, string title, string year)
        {
            universityTextboxObj.LocateEnterUniversityTextbox(driver, university);
            countryOptionsObj.Country(driver,country);
            titleOptionObj.Title(driver, title);
            degreeTexboxObj.LocateEnterDegreeTextbox(driver, degree);
            yearObj.YearOption(driver,year);
            clickAddButtonObj.ClickAddButton(driver);  //Locate Add button and click
          

        }

      
    }
}

