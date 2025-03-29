using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace MatchingEngine.Utils
{
    public class DriverManager
    {
         private static readonly string? browserName = ConfigurationManager.AppSettings["browser"];

        public static IWebDriver InitialiseBrowser(IWebDriver driver)
        {
            switch (browserName.ToLower())
            {
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
                case "Edge":
                    driver = new EdgeDriver();
                    break;
                case "Chrome":
                default:
                    driver = new ChromeDriver();
                    break;
            }


            return driver;

        }

    }
}
