using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloSalesforce.PageObjects
{
    class LoginPage
    {
        IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement nameElement;
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement passwordElement;
        [FindsBy(How = How.Id, Using = "Login")]
        private IWebElement loginElement;
        public bool Displayed => nameElement.Displayed;
        public void TypeName(string name)
        {
            nameElement.SendKeys(name);
        }
        public void TypePassword(string password)
        {
            passwordElement.SendKeys(password);
        }
        public void ClickLogin()
        {
            loginElement.Click();
        }
        public void Login(string name, string password)
        {
            TypeName(name);
            TypePassword(password);
            ClickLogin();
        }
    }
}
