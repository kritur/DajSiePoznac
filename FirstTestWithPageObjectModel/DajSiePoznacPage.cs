using FirstTestWithPageObjectModel.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FirstTestWithPageObjectModel
{
    public class DajSiePoznacPage : BasePage
    {
        [FindsBy(How = How.Name, Using = "s")]
        private IWebElement searchText;

        [FindsBy(How = How.ClassName, Using = "search-button")]
        private IWebElement searchButton;

        public DajSiePoznacPage(IWebDriver driver) : base(driver)
        {
            PageUrl = @"http://devstyle.pl";
        }

        public string SearchText
        {
            set { searchText.SendKeys(value); }
        }

        public SearchResultsPage SearchForText()
        {
            searchButton.Click();

            return new SearchResultsPage(Driver);
        }
    }
}
