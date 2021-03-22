using System;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Text;
using AcademiaTestePadra.Pages;

namespace AcademiaTestePadra.Models
{
    class HomePage_Model
    {
        private IWebDriver driver;
        private HomePage_Page home;
        public HomePage_Model(IWebDriver superDriver)
        {
            driver = superDriver;
            home = new HomePage_Page(driver);
        }



        public void navegaCriaUsuario()
        {
            Assert.IsTrue(home.linkItemPresentInSalle().Displayed);
            home.linkItemPresentInSalle().Click();

            //home.linkCriarUsuario().Click();
        }
    }
}
