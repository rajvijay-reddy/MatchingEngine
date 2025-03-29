using MatchingEngine.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MatchingEngine.Pages
{
    public class ReportPage
    {         
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public ReportPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Constants.TIME_IN_SECONDS));
        }

       private readonly By additonalFeatures = By.XPath("//h2[contains(text(), 'Additional Features')]");
       private readonly By prdSupportedContainer = By.XPath("//div[contains(@class,'vc_tta-container')]");
        private readonly By prdSupported = By.XPath("(//span[contains(text(), 'Products Supported')])[1]");
        private readonly By prdSupportedHeader = By.XPath("(//div[@class='wpb_wrapper']//h3[contains(@class,'vc_custom_heading')])[8]");
        private readonly By contactUs = By.XPath("//a[contains(text(),'Contact us!')]");


        public void MoveToAdditonalFeatures()
        {
            additonalFeatures.MoveToElement(driver);
        }

        public void MoveToPrdSupported()
        {
            prdSupportedContainer.MoveToElement(driver);
            prdSupported.MoveToElement(driver);
        }

        public void WaitForContactUs()
        {
            WebUtils.WaitForElementVisibilility(contactUs, driver);
        }

        public void ClickprdSupported()
        {
            IWebElement prdSupport = driver.FindElement(prdSupported);
            prdSupport.ClickElement(driver);
        }

        public string GetPrdSupportedHeaderText()
        {
            return prdSupportedHeader.GetTextByAttribute(driver);
        }

    }
}
