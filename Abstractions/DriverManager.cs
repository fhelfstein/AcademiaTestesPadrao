using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AcademiaTestePadra.Abstractions
{
    class DriverManager : IDisposable
    {
        protected IWebDriver driver { get; }
        public DriverManager()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            string url = "http://automationpractice.com/index.php";
            driver.Navigate().GoToUrl(url);
        }

        public void Dispose()
        {
            driver?.Quit();
            driver?.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
