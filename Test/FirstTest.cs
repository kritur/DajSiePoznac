using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Test
{
    public class FirstTest
    {
        [Test]
        public void DajSiePoznac()
        {
            using (IWebDriver driver = new ChromeDriver())

            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://devstyle.pl");

                IWebElement searchFieldElement = driver.FindElement(By.Name("s"));
                IWebElement searchButtonElement = driver.FindElement(By.ClassName("search-button"));

                searchFieldElement.SendKeys("Daj się poznać");
                searchButtonElement.Click();

                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d => d.Title.StartsWith("You searched", StringComparison.OrdinalIgnoreCase));

                Assert.AreEqual("You searched for Daj się poznać | devstyle.pl | Maciej Aniserowicz", driver.Title);
            }
        }

    }
}
