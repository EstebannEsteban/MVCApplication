using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace WebdriverFramework
{
    public class SignIn:AbstractWebPage
    {
              
        public SignIn(IWebDriver Driver)
            : base(Driver) { }

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        protected IWebElement BtnCreateAccount = null;

        public void ClickCreateAccountButton()
        {
            BtnCreateAccount.Click();
        }

    }
}
