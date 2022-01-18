using Dec2021.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace Dec2021.Pages
{
    class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // Create Time and Material record
            // Click on Administration dropdown button
            IWebElement adminstrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminstrationDropdown.Click();
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2);

            // Go to Time and Material page
            // Click on 'Time & Material' button
            IWebElement timeandmaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeandmaterialOption.Click();
        }
        public void GoToEmployeePage(IWebDriver driver)
        {
            // navigate to Employee page
            IWebElement adminstrationDropdownBtn = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            adminstrationDropdownBtn.Click();
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2);

            // note: click on 'employees' button
            IWebElement employeesOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeesOption.Click();
        }
    }
}
