using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework;

namespace CompetitionMars.Support
{

    public class HTMLReport
    {
        public  ExtentReports? extent;
        public ExtentTest? test;

        [OneTimeSetUp]
        public void Setup()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\Shuch\Desktop\CompetitionMars\Support\ExtentReport.html");
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            var test = extent.CreateTest("MyFirstTest", "Sample description");
            test.Log(Status.Info, "This step shows usage of log");

        }

        [OneTimeTearDown]
        public void TearDown()
        {
            extent.Flush();
        }
    }

}
