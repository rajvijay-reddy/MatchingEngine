using System;
using System.Configuration;
using OpenQA.Selenium.Support.UI;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using MatchingEngine.Utils;

namespace MatchingEngine.Test
{
    public class BaseTest
    {
        public ThreadLocal<IWebDriver> driver = new();
        protected WebDriverWait? wait;
        private static readonly string? baseUrl = ConfigurationManager.AppSettings["baseUrl"];


        [SetUp]
        public void LaunchBrowser() { 

             driver.Value = DriverManager.InitialiseBrowser(driver.Value);
                driver.Value.Manage().Window.Maximize();
                driver.Value.Navigate().GoToUrl(baseUrl);  
        }

        public IWebDriver GetDriver() => driver.Value;


    [TearDown]
        public void TearDown()
        {
            if (driver.Value!= null)
            {
                driver.Value.Quit();
                driver.Value.Dispose();
                driver.Value = null;
            }
        }

    }
}
