using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SaucedemoWithSpecflow.Pages
{
    public class PagesObject
    { WebDriver driver;
        public PagesObject(WebDriver driver)
        {
            this.driver = driver;
        }
        private BasePage BasePageObj;
        private LoginPage LoginPageObj;

        public BasePage GetBasePage()
        {
            if (BasePageObj == null)
            {
                BasePageObj = new BasePage();
            }
            return BasePageObj;
        }
        public LoginPage GetLoginPage()
        {
            if (LoginPageObj == null)
            {
                LoginPageObj = new LoginPage();
             }
            return LoginPageObj;
        }
    }
}
