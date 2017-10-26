using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVCApplication.Models.EntityManager;
using MVCApplication.Models.ViewModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebdriverFramework
{
    public class MainPage:AbstractWebPage
    {
        public MainPage(IWebDriver Driver)
            : base(Driver)
        {


        }

        public MainPage()
        {
                
        }

        public void InsertUser(UserSignUpView usertSignUpView)
        {
            UserManager user = new UserManager();
            user.AddUserAccount(usertSignUpView);
        }
        
    }
}
