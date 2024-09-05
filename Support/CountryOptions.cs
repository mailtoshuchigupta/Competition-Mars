using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionMars.Support
{
    public class CountryOptions
    {
        //Locating and clicking the Level dropdown
        public void Country(IWebDriver driver,string country)
        {
            IWebElement levelDropdown = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            levelDropdown.SendKeys(country);

           
        }
    }
}
