using MatchingEngine.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MatchingEngine.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public HomePage(IWebDriver driver) {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Constants.TIME_IN_SECONDS));
        }

        private readonly By moduleMenu = By.XPath("//a[contains(text(), 'Modules')]");
        IWebElement reportSubMenu => driver.FindElement(By.XPath("//a[contains(text(), 'Repertoire Management Module')]"));


        public void MoveToModuleMenu()
        {
            moduleMenu.MoveToElement( driver);
        }

        public void ClickReportSubMenu()
        {
            reportSubMenu.ClickElement(driver);
        }
       
    }
}
