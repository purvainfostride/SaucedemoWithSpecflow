using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SaucedemoWithSpecflow.Pages
{
    public class LoginPage:BasePage
    {
        By Username = By.Id("user-name");
        By Password = By.Id("password");
        By LoginButton = By.Id("login-button");
        public LoginPage()
        {
            PageFactory.InitElements(driver, this);
        }
        public void EnterCredentials(String uname, String pass)
        {
            driver.FindElement(Username).SendKeys(uname);
            driver.FindElement(Password).SendKeys(pass);

        }
        public void ClickLogin()
        {
            driver.FindElement(LoginButton).Click();
        }
        public void UserIsOnHomePage()
        {
            Assert.AreEqual(HomePageUrl, driver.Url);
        }
    }
}
