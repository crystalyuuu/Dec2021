using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Dec2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //open chrome browser
            //note:driver can be any name
            IWebDriver driver = new ChromeDriver();
            //need to maximize window
            driver.Manage().Window.Maximize();


            //launch turup portal
            //note:driver is ChromeDriver
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //identify username textbox and enter valid username
            //note:select username textbox and right click and find inspect, get the id name
            //note: usernameTextbox can be any name
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            //identify the password textbox and enter valid password
            //note:select password textbox and right click and find inspect, get the password name
            //note: passwordTextbox can be any name
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            //click on login button
            //note: dont have id, right click the and find inspect
            //note:then find the code, right click, find the copy, then find XPath for this element
            //note:change id double quote to single quote
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            //check if user is logged in successfully
            //note: login then find 'HelloHari', right click and find inspect, then find XPath
            //note: chagne id double quote to single quote
            IWebElement hellloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            //if text is Hello hari! then succesful, otherwise, login failed
            if(hellloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Login failed, test failed.");
            }

        }
    }
}