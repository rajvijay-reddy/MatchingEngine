using System.Xml.Linq;
using MatchingEngine.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using static System.Net.WebRequestMethods;

namespace MatchingEngine.Test
{
    [TestFixture]
    public class MatchingEngineTest : BaseTest
    {
        private HomePage homePage;
        private ReportPage reportPage;


        [SetUp]
        public void Before()
        {
            reportPage = new ReportPage(GetDriver());
            homePage = new HomePage(GetDriver());
            
        }

        [Test(Description = "Verify header")]
        public void ProductSupportTest()
        {
            homePage.MoveToModuleMenu();
            homePage.ClickReportSubMenu();

            
            reportPage.WaitForContactUs();
           reportPage.MoveToAdditonalFeatures();
            reportPage.MoveToPrdSupported();
            reportPage.ClickprdSupported();
            string prdSupportHeader = reportPage.GetPrdSupportedHeaderText();
            Assert.That(prdSupportHeader, Is.EqualTo("There are several types of Product Supported:"), "Product Support header doesn't match");
        }

    }
}