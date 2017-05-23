using FirstTestWithPageObjectModel;
using FirstTestWithPageObjectModel.Common;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Test
{
    public class DajSiePoznacTests
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void DajSiePoznac()
        {
            var dajSiePoznacPage = driver.NavigateTo<DajSiePoznacPage>();

            dajSiePoznacPage.SearchText = "Daj się poznać";
            var searchResultsPage = dajSiePoznacPage.SearchForText();

            Assert.True(searchResultsPage.MainHeading.Contains("SEARCH RESULTS: DAJ SIĘ POZNAĆ"));
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Dispose();
        }
    }
}
