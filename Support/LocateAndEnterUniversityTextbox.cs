using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionMars.Support
{
    public class LocateAndEnterUniversityTextbox
    {
        //Locating and sending input to University textbox
        public  void LocateEnterUniversityTextbox(IWebDriver driver, string university)
        {
            IWebElement languageTextbox = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input\r\n"));
            languageTextbox.SendKeys(university);
        }
    }
}
