using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SaucedemoWithSpecflow.Pages
{
    public class BasePage
    {
        public static WebDriver driver;
        public static PagesObject Obj;

        public String LoginUrl = "https://www.saucedemo.com/";
        public String HomePageUrl = "https://www.saucedemo.com/inventory.html";
        
        public void LaunchBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Cookies.DeleteAllCookies();                   
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(LoginUrl);           
        }
        
        [TearDown]
        public void ClosingBrowser()
        {
            driver.Quit();
        }
    }
}
