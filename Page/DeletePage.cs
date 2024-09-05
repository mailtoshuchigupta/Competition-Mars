using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports.Reporter;
using CompetitionMars.Support;

namespace CompetitionMars.Pages
{
    public class DeletePage
    {
        public void DeleteEducation(IWebDriver driver)
        {

            //Locate Remove icon button and deleting the existing Education
            try
            {
            while (true)
            {

                IWebElement removeIconButton = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[2]/i"));
                removeIconButton.Click();
                Thread.Sleep(2000);
            }

            }

             catch (Exception ex)
             {
               // Assert.Pass("All the Educations has been removed");


            }
            
        }

    }
}
