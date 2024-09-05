using System;
using TechTalk.SpecFlow;
using CompetitionMars.Drivers;
using CompetitionMars.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Text.Json.Nodes;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.IO;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using CompetitionMars.Support;


namespace CompetitionMars.StepDefinitions
{
    [Binding]
    public class EducationStepDefinitions : CommonDriver
    {

        DeletePage deletePageObj = new DeletePage();
        AddEducationPage AddEduationPageObj = new AddEducationPage();
        UpdateEducationPage updateEduationPageObj = new UpdateEducationPage();
        [Given(@"Education Tab is selected in Profile Page/")]
        public void GivenEducationTabIsSelectedInProfilePage()
        {
            // Navigating to educaion Page
            IWebElement educationTab = driver.FindElement(By.XPath("//*/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();
            Console.WriteLine("Mars portal is Starting");

        }

        [When(@"I click on Cross icon buttons")]
        public void WhenIClickOnCrossIconButtons()
        {
            deletePageObj.DeleteEducation(driver);
        }

        [Then(@"Existing Educations deleted successfully")]
        public void ThenExistingEducationsDeletedSuccessfully()
        {

            try
            {

                driver.FindElement(By.XPath("//*/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td[6]/span[2]/i"));
            }
            catch (NoSuchElementException)
            {

                Console.WriteLine("12334566");
                // Assert.Pass("All Educations are deleted");


            }
        }

        [When(@"I click on Add New buttons")]
        public void WhenIClickOnAddNewButtons()
        {
            AddEduationPageObj.AddEducation(driver);

        }

        [When(@"I give valid input <'([^']*)'>,<'([^']*)'>,<'([^']*)'>,<'([^']*)'>,<'([^']*)'> of Education")]
        public void WhenIGiveValidInputOfEducation(string university, string country, string title, string degree, string year)
        {
            const string FilePath = @"C:\Users\Shuch\Desktop\CompetitionMars\Support\validinputs.json";


            string jsonString = File.ReadAllText(FilePath);
            Console.WriteLine(jsonString);

            // Parse the JSON string into a JsonDocument
            using (JsonDocument doc = JsonDocument.Parse(jsonString))
            {
                // Get the root element (which is an array in this case)
                JsonElement root = doc.RootElement;

                // Iterate through each item in the array
                foreach (JsonElement item in root.EnumerateArray())
                {
                    // Access individual properties of each object
                    string uni = item.GetProperty("university").GetString();
                    string deg = item.GetProperty("degree").GetString();
                    string coun = item.GetProperty("country").GetString();
                    string tit = item.GetProperty("title").GetString();
                    string yr = item.GetProperty("year").GetString();


                    AddEduationPageObj.InputEducation(driver, uni, deg, coun, tit, yr);

                    AddEduationPageObj.AddEducation(driver);
                }
            }





        }


        [Then(@"Education should be added")]
        public void ThenEducationShouldBeAdded()
        {


            IWebElement languageRead = driver.FindElement(By.XPath("/html/body/div[1]/div"));

            Assert.That(languageRead.Text, Is.EqualTo("Education has been added"), "Education is not added");

            deletePageObj.DeleteEducation(driver);

        }

        [When(@"I click on Add New buttons for invalid input")]
        public void WhenIClickOnAddNewButtonsForInvalidInput()
        {
            AddEduationPageObj.AddEducation(driver);
            //throw new PendingStepException();
        }





        [When(@"I give invalid input <'([^']*)'>,<'([^']*)'>,<'([^']*)'>,<'([^']*)'>,<'([^']*)'> of Education")]
        public void WhenIGiveInvalidInputOfEducation(string university, string country, string title, string degree, string year)
        {
            const string FilePath = @"C:\Users\Shuch\Desktop\CompetitionMars\Support\invalidinputs.json";


            string jsonString = File.ReadAllText(FilePath);
            Console.WriteLine(jsonString);

            // Parse the JSON string into a JsonDocument
            using (JsonDocument doc = JsonDocument.Parse(jsonString))
            {
                // Get the root element (which is an array in this case)
                JsonElement root = doc.RootElement;

                // Iterate through each item in the array
                foreach (JsonElement item in root.EnumerateArray())
                {
                    // Access individual properties of each object
                    string uni = item.GetProperty("university").GetString();
                    string deg = item.GetProperty("degree").GetString();
                    string coun = item.GetProperty("country").GetString();
                    string tit = item.GetProperty("title").GetString();
                    string yr = item.GetProperty("year").GetString();


                    AddEduationPageObj.InputEducation(driver, uni, deg, coun, tit, yr);

                }
            }
        }

        [Then(@"Education should not be added")]
        public void ThenEducationShouldNotBeAdded()
        {
            IWebElement languageRead = driver.FindElement(By.XPath("/html/body/div[1]/div"));

            Assert.That(languageRead.Text, !Is.EqualTo("Education has been added"), "Education is added");

        }

        [When(@"I click on Add New buttons for long input")]
        public void WhenIClickOnAddNewButtonsForLongInput()
        {
            AddEduationPageObj.AddEducation(driver);
        }

        [When(@"I give long input <'([^']*)'>,<'([^']*)'>,<'([^']*)'>,<'([^']*)'>,<'([^']*)'> of Education")]
        public void WhenIGiveLongInputOfEducation(string university, string country, string title, string degree, string year)
        {
            const string FilePath = @"C:\Users\Shuch\Desktop\CompetitionMars\Support\Longinput.json";


            string jsonString = File.ReadAllText(FilePath);
            Console.WriteLine(jsonString);

            // Parse the JSON string into a JsonDocument
            using (JsonDocument doc = JsonDocument.Parse(jsonString))
            {
                // Get the root element (which is an array in this case)
                JsonElement root = doc.RootElement;

                // Iterate through each item in the array
                foreach (JsonElement item in root.EnumerateArray())
                {
                    // Access individual properties of each object
                    string uni = item.GetProperty("university").GetString();
                    string deg = item.GetProperty("degree").GetString();
                    string coun = item.GetProperty("country").GetString();
                    string tit = item.GetProperty("title").GetString();
                    string yr = item.GetProperty("year").GetString();


                    AddEduationPageObj.InputEducation(driver, uni, deg, coun, tit, yr);
                }
            }
        }

        [Then(@"Education shouldn't add")]
        public void ThenEducationShouldntAdd()
        {
            IWebElement languageRead = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            Assert.That(languageRead.Text, !Is.EqualTo("Education has been added"), "Education is added");
            deletePageObj.DeleteEducation(driver);
        }

        [Given(@"one education is added")]
        public void GivenOneEducationIsAdded()
        {
            AddEduationPageObj.AddEducation(driver);
            const string FilePath = @"C:\Users\Shuch\Desktop\CompetitionMars\Support\validinputs.json";


            string jsonString = File.ReadAllText(FilePath);
            Console.WriteLine(jsonString);

            // Parse the JSON string into a JsonDocument
            using (JsonDocument doc = JsonDocument.Parse(jsonString))
            {
                // Get the root element (which is an array in this case)
                JsonElement root = doc.RootElement;

                // Iterate through each item in the array
                foreach (JsonElement item in root.EnumerateArray())
                {
                    // Access individual properties of each object
                    string uni = item.GetProperty("university").GetString();
                    string deg = item.GetProperty("degree").GetString();
                    string coun = item.GetProperty("country").GetString();
                    string tit = item.GetProperty("title").GetString();
                    string yr = item.GetProperty("year").GetString();


                    AddEduationPageObj.InputEducation(driver, uni, deg, coun, tit, yr);
                    Thread.Sleep(6000);

                    AddEduationPageObj.AddEducation(driver);
                    
                }
            }
        }

        [When(@"I click on update buttons")]
        public void WhenIClickOnUpdateButtons()
        {
            updateEduationPageObj.UpdateIconEducation(driver);
        }

        [When(@"I give new input <'([^']*)'>,<'([^']*)'> of Education to update")]
        public void WhenIGiveNewInputOfEducationToUpdate(string university, string degree)
        {
            const string FilePath = @"C:\Users\Shuch\Desktop\CompetitionMars\Support\updateinput.json";


            string jsonString = File.ReadAllText(FilePath);
            Console.WriteLine(jsonString);

            // Parse the JSON string into a JsonDocument
            using (JsonDocument doc = JsonDocument.Parse(jsonString))
            {
                // Get the root element (which is an array in this case)
                JsonElement root = doc.RootElement;

                // Iterate through each item in the array
                foreach (JsonElement item in root.EnumerateArray())
                {
                    // Access individual properties of each object
                    string uni = item.GetProperty("university").GetString();
                    string deg = item.GetProperty("degree").GetString();
                    string coun = item.GetProperty("country").GetString();
                    string tit = item.GetProperty("title").GetString();
                    string yr = item.GetProperty("year").GetString();


                    updateEduationPageObj.InputupdateEducation(driver, uni, deg);//, coun, tit, yr);
                    Thread.Sleep(2000);

                }


                           }
        }

        [Then(@"Education should be updated")]
        public void ThenEducationShouldBeUpdated()
        {
            IWebElement languageRead = driver.FindElement(By.XPath("/html/body/div[1]/div"));
            Assert.That(languageRead.Text, Is.EqualTo("Education as been updated"), "Education is not updated");
        }

    }
}

