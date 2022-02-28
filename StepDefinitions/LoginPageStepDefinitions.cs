using System;
using TechTalk.SpecFlow;
using SaucedemoWithSpecflow.Pages;
using OpenQA.Selenium;
using NUnit.Framework;

namespace SaucedemoWithSpecflow.StepDefinitions
{
    [Binding]
    public class LoginPageStepDefinitions:BasePage

    {
        [Given(@"User is on Login Page")]
        public void GivenUserIsOnLoginPage()
        {
            Obj.GetBasePage().LaunchBrowser();
        }

        [When(@"User enter ""([^""]*)"" and ""([^""]*)""")]
        public void UserEnterCredentials(string uname, string pass)
        {
            Obj.GetLoginPage().EnterCredentials(uname,pass);
        }

        [When(@"User click on login button")]
        public void WhenUserClickOnLoginButton()
        {
            Obj.GetLoginPage().ClickLogin();
        }

        [Then(@"User is on Inventory page")]
        public void ThenUserIsOnInventoryPage()
        {
            Obj.GetLoginPage().UserIsOnHomePage();

        }

        





    }
}
