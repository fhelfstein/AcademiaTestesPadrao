using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaTestePadra.Pages
{
    class HomePage_Page
    {

        private IWebDriver driver;
        public HomePage_Page(IWebDriver superDriver)
        {
            driver = superDriver;
        }

        public IWebElement linkItemPresentInSalle()
        {
            return driver.FindElement(By.XPath("//*[@id='homefeatured']/li[1]/div/div[2]/h5/a"));
        }

        public IWebElement txtNameProductInPageProduct()
        {
            return driver.FindElement(By.CssSelector(".pb-center-column>h1"));
        }

    }
}
