using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebdriverFramework
{
    public abstract class AbstractWebPage
    {

        private IWebDriver _driver;

        protected AbstractWebPage(IWebDriver Driver)
        {
            _driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        protected AbstractWebPage()
        {
            

        }
    }
}
