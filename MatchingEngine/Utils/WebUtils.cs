using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MatchingEngine.Utils
{
    public static class WebUtils
    {
 
        public static void MoveToElement(this By locator, IWebDriver driver)
        {
            locator.WaitForElementVisibilility(driver);
            Actions action = new Actions(driver);
            IWebElement element = driver.FindElement(locator);
            action.MoveToElement(element).Perform();
        }

        public static void ClickElement(this IWebElement locator, IWebDriver driver)
        {
            locator.WaitForElementToBeClickable(driver);
            locator.Click();
        }

        public static string GetText(this IWebElement locator)
        {

            return locator.Text;
        }

        public static string GetTextByAttribute(this By locator, IWebDriver driver)
        {
           
                WebUtils.WaitForElementVisibilility(locator, driver);
                IWebElement element = driver.FindElement(locator);
                return element.GetAttribute("textContent");

        }


        public static void WaitForElementToBeClickable(this IWebElement locator, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Constants.TIME_IN_SECONDS));

            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public static void WaitForElementVisibilility(this By locator, IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Constants.TIME_IN_SECONDS));

            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }
    }
}

