using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebdriverFramework
{
    public static class Driver
    {
        public static IWebDriver WebDriver;

        public static IWebDriver StartBrowser()
        {
            WebDriver = new FirefoxDriver();
            return WebDriver;
        }
    }
}
