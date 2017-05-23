using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace FirstTestWithPageObjectModel.Common
{
    public class BasePage
    {
        protected IWebDriver Driver { get; }

        public string PageUrl { get; protected set; }

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(Driver, this);
        }
    }
}