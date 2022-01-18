using Dec2021.Pages;
using Dec2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Dec2021.StepDefinitions
{
    [Binding]
    public class TMFeatureStep : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Given(@"\[I logged into turnup portal successfully]")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            //LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [Given(@"\[I navigate to time and material page]")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            // Home page object initialization and definition
            //HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [When(@"\[I create a time and material record]")]
        public void WhenICreateATimeAndMaterialRecord()
        {
            // TM page object initialization and definition
            //TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }

        [Then(@"\[the record should be created successfully]")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            // note: create object for tm page
            //TMPage tmPageObj = new TMPage();
            // get actual value return in getCode function

            string actualCode = tmPageObj.GetCode(driver);
            string actualTypeCode = tmPageObj.GetTypeCode(driver);
            string actualDescription = tmPageObj.GetDescription(driver);
            string actualPrice = tmPageObj.GetPrice(driver);

            Assert.That(actualCode == "Dec2021", "Actual Code and expected code do not match.");
            Assert.That(actualTypeCode == "M", "Actual TypeCode and expected code do not match.");
            Assert.That(actualDescription == "Dec2021", "Actual Description and expected code do not match.");
            Assert.That(actualPrice == "$1,234.00", "Actual Price and expected code do not match.");
        }

        [When(@"\[I update '([^']*)' and '([^']*)' an existing time and material record]")]
        public void WhenIUpdateAndAnExistingTimeAndMaterialRecord(string p0, string p1)
        {
            tmPageObj.EditTM(driver, p0, p1);
        }

        [Then(@"\[the record should be updated '([^']*)' and '([^']*)']")]
        public void ThenTheRecordShouldBeUpdatedAnd(string p0, string p1)
        {
            string editedDescription = tmPageObj.GetEditedDescription(driver);
            string editedCode = tmPageObj.GetEditedCode(driver);

            Assert.That(editedDescription == p0, "Actual editedDescription and expected code do not match.");
            Assert.That(editedCode == p1, "Actual editedCode and expected code do not match.");

        }





    }
}
