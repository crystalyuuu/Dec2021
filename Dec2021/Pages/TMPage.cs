using Dec2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Dec2021.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click on Create New Button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            // Select Material from TypeCode dropdown
            // note: click on arrow dropdown button
            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            Thread.Sleep(2000);

            // note: select material option
            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            materialOption.Click();

            // Identify the Code textbox and input a code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("Dec2021");

            // Identify the Description textbox and input a description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Dec2021");

            // Identify the Price textbox and input a price
            //overlapping: first select the textbox, then find display change from none to inline-block
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();
            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("1234");

            // Click on Save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 5);

            // Click on go to last page button
            // note: use the last page arrow
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(2000);

            // check if record created is present in the table and has expected value
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement actualTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement actualDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement actualPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            // Option 1
            // note: check all information in table are correct.if acutalCode.Text = correct information, then show else information.
            Assert.That(actualCode.Text == "Dec2021", "Actual code and expected code do not match.");
            Assert.That(actualTypeCode.Text == "M", "Actual typecode and expected typecode do not match.");
            Assert.That(actualDescription.Text == "Dec2021", "Actual description and expected description do not match.");
            Assert.That(actualPrice.Text == "$1,234.00", "Actual price and expected price do not match.");

            // Option 2
            // note: check the information in the first column is correct.
            //if (actualCode.Text == "Dec2021")
            //{
            //    Assert.Pass("Material record created successfully, test passed.");
            //}
            //else
            //{
            //    Assert.Fail("Test failed.");
            //}
        }

        public void EditTM(IWebDriver driver)
        {
            Thread.Sleep(3000);
            // Click on go to last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            goToLastPageButton.Click();

            IWebElement findRecordCreated = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findRecordCreated.Text == "Dec2021")
            {
                // click edit Button
                // find existing record and edit it. Then show else information.
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
            }
            else
            {
                Assert.Fail("Record to be edited hasn't been found. Record not edited");
            }

            // Edit existing code
            IWebElement editCode = driver.FindElement(By.Id("Code"));
            editCode.Clear();
            editCode.SendKeys("editcodetest");

            // Edit description
            IWebElement editdescription = driver.FindElement(By.Id("Description"));
            editdescription.Clear();
            editdescription.SendKeys("editdescriptiontest");

            // Edit price
            IWebElement editPrice = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement editPriceTextbox = driver.FindElement(By.Id("Price"));

            editPrice.Click();
            editPriceTextbox.Clear();
            editPrice.Click();
            editPriceTextbox.SendKeys("999");

            // Save code which edited
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
            editSaveButton.Click();
            Thread.Sleep(2000);

            // Go to the last page and check the record is present and edited.
            IWebElement lastPageEditCheck = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageEditCheck.Click();
            Thread.Sleep(2000);

            // Assertion
            IWebElement CreatedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement CreatedTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            IWebElement CreatedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement CreatedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            // Assertion
            Assert.That(CreatedCode.Text == "editcodetest", "Actual code and expected code do not match.");
            Assert.That(CreatedTypeCode.Text == "M", "Actual typecode and expected typecode do not match.");
            Assert.That(CreatedDescription.Text == "editdescriptiontest", "Actual description and expected description do not match.");
            Assert.That(CreatedPrice.Text == "$999.00", "Actual price and expected price do not match.");

        }

        public void DeleteTM(IWebDriver driver)
        {
            Thread.Sleep(3000);
            // Click on go to last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            goToLastPageButton.Click();

            IWebElement findEditedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findEditedRecord.Text == "editcodetest")
            {
                // Click on the Delete Button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
                deleteButton.Click();
                Thread.Sleep(2000);

                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found. Record not deleted.");
            }

            // Assert that Time record has been deleted.
            // check if the existing element has been deleted or not.
            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(2000);

            IWebElement editedExistingCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedExistingDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editedExistingPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));

            // Assertion
            Assert.That(editedExistingCode.Text != "editcodetest", "Code record hasn't been deleted.");
            Assert.That(editedExistingDescription.Text != "editdescriptiontest", "Description record hasn't been deleted.");
            Assert.That(editedExistingPrice.Text != "$999.00", "Price record hasn't been deleted.");


        }
    }
}

