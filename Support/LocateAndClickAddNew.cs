using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   CompetitionMars.Support
{
    public class LocateAndClickAddNew
    {
        //Locating and clicking Add New button
        public void LocateClickAddNew(IWebDriver driver)
        {
            IWebElement addNewButton = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNewButton.Click();                                   
        }
    }
}
