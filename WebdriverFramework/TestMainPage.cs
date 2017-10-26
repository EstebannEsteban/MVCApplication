using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCApplication.Models.ViewModel;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebdriverFramework
{
    public class TestMainPage:BaseTest<MainPage>
    {

        [Test]
        public void CreateAccount()
        {
            var mainPage = InitialPage;
            var signIn = mainPage.clickSignInButton();
            signIn.ClickCreateAccountButton();

        }

        [Test]
        public void LoadMainPage()
        {
            
            var mainPage = InitialPage;

            var userSignUpView = new UserSignUpView
            {
                SYSUserID = 0,
                Gender = "M",
                FirstName = "Name 1",
                LastName = "Last 2",
                LoginName = "name1",
                LOOKUPRoleID = 1,
                Password = "123",
                RoleName = "Epa"
                
            };

            mainPage.InsertUser(userSignUpView);



        }
    }
}
