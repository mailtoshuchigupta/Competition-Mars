using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionMars.Support
{
    public class LocateAndEnterDegreeTextbox
    {
        //Locating and sending input to Language textbox
        public void LocateEnterDegreeTextbox(IWebDriver driver, string degree)
        {
            IWebElement languageTextbox = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            languageTextbox.SendKeys(degree);
        }
    }
}
