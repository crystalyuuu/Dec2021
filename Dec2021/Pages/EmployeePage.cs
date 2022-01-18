using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dec2021.Pages
{
    class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        {
            //// Click create new employees button
            //IWebElement createEmployeeButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            //createEmployeeButton.Click();

            //// Identify the Name textbox and input a name in alphabet
            //IWebElement nameTextbox = driver.FindElement(By.Id("Name"));
            //nameTextbox.SendKeys("ha ri");

            //// Identify the Username textbox and input a name in alphabet
            //IWebElement usernameTextbox = driver.FindElement(By.Id("Username"));
            //usernameTextbox.SendKeys("hari123");

            //Thread.Sleep(3000);
            //// Click the Eidt Contact button
            //IWebElement editContactButton = driver.FindElement(By.Id("EditContactButton"));
            //editContactButton.Click();

            //Thread.Sleep(3000);
            //// ?????????????????cannot type in the textbox???????????????????????????????????

            //// Identify the Eidt Contact textbox and input all personal information
            //IWebElement firstName = driver.FindElement(By.Id("FirstName"));
            //firstName.SendKeys("ha");

            //IWebElement lastName = driver.FindElement(By.Id("LastName"));
            //lastName.SendKeys("ri");

            //IWebElement preferedName = driver.FindElement(By.Id("PreferedName"));
            //preferedName.SendKeys("harry");

            //IWebElement phone = driver.FindElement(By.Id("Phone"));
            //phone.SendKeys("123456");

            //IWebElement mobile = driver.FindElement(By.Id("Mobile"));
            //mobile.SendKeys("654321");

            //IWebElement fax = driver.FindElement(By.Id("Fax"));
            //fax.SendKeys("1234");

            //// adress searching: enter your address

            //IWebElement street = driver.FindElement(By.Id("Street"));
            //street.SendKeys("1 Hari Street");

            //IWebElement city = driver.FindElement(By.Id("City"));
            //city.SendKeys("Wellington");

            //IWebElement postcode = driver.FindElement(By.Id("Postcode"));
            //postcode.SendKeys("4321");

            //IWebElement country = driver.FindElement(By.Id("Country"));
            //country.SendKeys("New Zealand");

            //IWebElement saveContactButton = driver.FindElement(By.Id("submitButton"));
            //saveContactButton.Click();

            //// enter employee password
            //IWebElement emoloyeepassword = driver.FindElement(By.Id("Password"));
            //emoloyeepassword.SendKeys("12345Aa.");
            //// retype password
            //IWebElement retypePassword = driver.FindElement(By.Id("RetypePassword"));
            //retypePassword.SendKeys("12345Aa.");
            //// click isadmin button
            //IWebElement isAdminButton = driver.FindElement(By.Id("IsAdmin"));
            //isAdminButton.Click();
            //// enter employee vehicle name
            //IWebElement vehicle = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            //vehicle.SendKeys("toyota");
            //// select groups
            //IWebElement groups = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[8]/div/div/div[1]"));
            //groups.Click();

            //IWebElement groupName = driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[1]"));
            //groupName.Click();

            //// save employee's personal detail
            //IWebElement saveEmployeeButton = driver.FindElement(By.Id("SaveButton"));
            //saveEmployeeButton.Click();
        }

    

        public void EditEmployee(IWebDriver driver)
        {

        }

        public void DeleteEmployee(IWebDriver driver)
        {

        }
    }
}