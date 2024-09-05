using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionMars.Support
{
    public class LocateClickAddButton
    {
        //Locating and clicking Add button
        public void ClickAddButton(IWebDriver driver)
        {

            IWebElement addButton = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addButton.Click();

        }
    }
}
