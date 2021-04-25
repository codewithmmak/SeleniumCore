using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumCore
{
    [TestClass]
    public class LoginpageFeature
    {
        IWebDriver _driver;
        [TestMethod]
        public void ShouldBeAbleToLogin()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");


            var logInPanelHeading = By.CssSelector("#logInPanelHeading");
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(logInPanelHeading));

            var userNameField = _driver.FindElement(By.CssSelector("#txtUsername"));
            var passwordField = _driver.FindElement(By.CssSelector("#txtPassword"));
            var loginButton = _driver.FindElement(By.CssSelector("#btnLogin"));

            userNameField.SendKeys("admin");
            passwordField.SendKeys("admin123");
            loginButton.Click();

            Assert.IsTrue(_driver.Url.Contains("index.php/dashboard"));
        }

        [TestCleanup]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}
