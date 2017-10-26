using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebdriverFramework
{
    public class BaseTest<T>
    {
        public T InitialPage;
        private IWebDriver _driver;

        [TestFixtureSetUp]
        public void SetUp()
        {
            _driver = Driver.StartBrowser();
            InitialPage = (T)Activator.CreateInstance(typeof(T), _driver);
            //InitialPage = new T();
            _driver.Navigate().GoToUrl("http://automationpractice.com");
            
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Dispose();
        }

    }
}
