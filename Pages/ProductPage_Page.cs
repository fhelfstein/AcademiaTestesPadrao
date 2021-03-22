using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaTestePadra.Pages
{
    class ProductPage_Page
    {
        private IWebDriver driver;
        public ProductPage_Page(IWebDriver superDriver)
        {
            driver = superDriver;
        }
    }
}
