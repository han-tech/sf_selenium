using HelloSalesforce.PageObjects;
using SeleniumExtras.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using TestProject.SDK.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace HelloSalesforce
{
    [TestClass]
    public class UnitTest1
    {
        string name = "peaceman77@hotmail.com";
        string password = "Cuulong123";
        [TestMethod]
        public void TestLoginSimple()
        {
            // Create driver
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--headless");
            var driver = new ChromeDriver(chromeOptions);
            WebDriverWait customWait = new WebDriverWait(driver, TimeSpan.FromMinutes(60));
            // Navigate to example page
            driver.Navigate().GoToUrl("https://login.salesforce.com/");
            var loginPage = PageFactory.InitElements<LoginPage>(driver);
            loginPage.Login(name, password);
            driver.Quit();
        }
    }
}
