using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionMars.Support
{
    public class YearOptions
    {
        //Locating and clicking the Level dropdown
        public void YearOption(IWebDriver driver, string year)
        {
            IWebElement levelDropdown = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            levelDropdown.SendKeys(year);

           // IWebElement optionValue = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[7]"));
            //optionValue.Click();

            /*
             * //Navigating through the level options
            if (level == "Basic")
            {
                IWebElement optionValue = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
                optionValue.Click();
            }
            if (level == "Native")
            {
                IWebElement optionValue = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]"));
                optionValue.Click();
            }
            if (level == "Fluent")
            {
                IWebElement optionValue = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
                optionValue.Click();

            }
            if (level == "Conversational")
            {
                IWebElement optionValue = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
                optionValue.Click();
            }*/
        }
    }
}
