using System;
using OpenQA.Selenium;

namespace FirstTestWithPageObjectModel.Common
{
    public static class DriverExtensions
    {
        public static TPage NavigateTo<TPage>(this IWebDriver driver) where TPage: BasePage
        {
            var page = (TPage) Activator.CreateInstance(typeof(TPage), driver);
            driver.Navigate().GoToUrl(page.PageUrl);

            return page;
        }
    }
}