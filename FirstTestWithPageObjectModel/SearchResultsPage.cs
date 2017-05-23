using FirstTestWithPageObjectModel.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FirstTestWithPageObjectModel
{
    public class SearchResultsPage: BasePage
    {
        [FindsBy(How = How.CssSelector, Using = ".main-heading")]
        private IWebElement mainHeading;

        public string MainHeading => mainHeading.Text;

        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
