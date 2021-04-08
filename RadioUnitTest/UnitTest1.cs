using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RadioRest.Models;
using RadioRest.Manager;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace RadioUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly string DriverDirectory = "C:\\Code\\WebDrivers";
        private static IWebDriver _driver;

        private RadioManager RManager = new RadioManager();

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _driver = new ChromeDriver(DriverDirectory); // fast
            // if your Chrome browser was updated, you must update the driver as well ...
            //    https://chromedriver.chromium.org/downloads
            /*_driver = new FirefoxDriver(DriverDirectory);*/  // slow
        }

        [TestMethod]
        public void TestMethod1()
        {
            List<MusicRecord> records = RManager.GetAll();
            Assert.AreEqual(2, records.Count);
            Assert.AreEqual("Justin Biber", records[0].Artist);
            Assert.AreEqual(2009, records[1].YearOfPublication);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string url = "https://pairprogram-radiorest.azurewebsites.net/api/radios";
            _driver.Navigate().GoToUrl("https://pairpromusicrecords.azurewebsites.net/");

            IWebElement buttonElement = _driver.FindElement(By.Id("GetAllButton"));
            buttonElement.Click();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement recordList = wait.Until(d => d.FindElement(By.Id("recordlists")));
            Assert.IsTrue(recordList.Text.Contains("Baby"));
        }

        [TestMethod]
        public void TestMethodUS2()
        {
            string url = "https://pairprogram-radiorest.azurewebsites.net/api/radios";
            _driver.Navigate().GoToUrl("https://pairpromusicrecords.azurewebsites.net/");

            IWebElement inputElement = _driver.FindElement(By.Id("GetByIdInput"));
            inputElement.SendKeys("2");
            IWebElement buttonElement = _driver.FindElement(By.Id("GetByIdButton"));
            buttonElement.Click();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement recordList = wait.Until(d => d.FindElement(By.Id("singleunit")));
            Assert.IsTrue(recordList.Text.Contains("Black Eye Peace"));
        }

        [TestMethod]
        public void TestMethodUS3()
        {
            string url = "https://pairprogram-radiorest.azurewebsites.net/api/radios";
            _driver.Navigate().GoToUrl("https://pairpromusicrecords.azurewebsites.net/");

            IWebElement inputElementTitle = _driver.FindElement(By.Id("AddTitleInput"));
            inputElementTitle.SendKeys("Otherside");
            IWebElement inputElementArtist = _driver.FindElement(By.Id("AddArtistInput"));
            inputElementArtist.SendKeys("Red Hot Chili Peppers");
            IWebElement inputElementDuration = _driver.FindElement(By.Id("AddDurationInput"));
            inputElementDuration.SendKeys("255");
            IWebElement inputElementYear = _driver.FindElement(By.Id("AddYearInput"));
            inputElementYear.SendKeys("2011");
            IWebElement buttonElementAdd = _driver.FindElement(By.Id("AddMusicRecordButton"));
            buttonElementAdd.Click();
            IWebElement buttonElement = _driver.FindElement(By.Id("GetAllButton"));
            buttonElement.Click();

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement recordList = wait.Until(d => d.FindElement(By.Id("recordlists")));
            Assert.IsTrue(recordList.Text.Contains("Otherside"));
        }
    }
}
