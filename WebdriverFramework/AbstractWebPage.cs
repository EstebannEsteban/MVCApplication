﻿using OpenQA.Selenium;
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

        protected T NewPage<T>() where T : AbstractWebPage
        {
            return (T)Activator.CreateInstance(typeof(T), _driver);
            //return (T)Activator.CreateInstance(typeof(T));

        }
    }
}
