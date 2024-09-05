using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionMars.Pages
{
    public class UpdateEducationPage
    {

        public void UpdateIconEducation(IWebDriver driver)
        {

            //Locate Pencil icon button and click
            IWebElement pencilButton = driver.FindElement(By.XPath("//*/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[1]/i"));
            pencilButton.Click();
            Thread.Sleep(3000);
        }
        public void InputupdateEducation(IWebDriver driver, string university, string degree)//, string country, string title, string year)

        {

            //Locate existing University, remove it and add new University
            IWebElement updateUniversityTextbox = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[1]/div[1]/input"));
        updateUniversityTextbox.Clear();                                      //*/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input
            updateUniversityTextbox.SendKeys(university);

            //Locate Update Country dropdown, click and choose Australia
            //IWebElement updateCountryDropdown = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            //updateCountryDropdown.Click();
            //IWebElement chooseCountryOption = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[6]"));
            //chooseCountryOption.SendKeys(country);

            //Locate Update Title dropdown, click and choose ------
            //IWebElement updateTitleDropdown = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select\r\n"));
            //updateTitleDropdown.Click();
            //IWebElement chooseTitleOption = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[3]"));
            //chooseTitleOption.SendKeys(title);*/

            //Locate existing Degree, remove it and add new Degree
            IWebElement updateDegreeTextbox = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[2]/div[2]/input"));
            updateDegreeTextbox.Clear();
            updateDegreeTextbox.SendKeys(degree);

           
            // Locate Update Year dropdown, click and choose 2016
            //IWebElement updateYearDropdown = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select\r\n"));
            //updateYearDropdown.Click();
            //IWebElement chooseYearOption = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[8]"));
            //chooseYearOption.SendKeys(year);

            //Locate Update button and click
            IWebElement updateButton = driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td/div[3]/input[1]"));
            updateButton.Click();

        }
    }
}

