using AcademiaTestePadra.Abstractions;
using AcademiaTestePadra.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaTestePadra.Tests
{
    class HomepageTest: DriverManager
    {
        private HomePage_Model home;
        
        
        public HomepageTest() : base()
        {
            home = new HomePage_Model(this.driver);
        }

        [SetUp]
        public void SetUpTest() {
            home = new HomePage_Model(this.driver);
        }

/*        [Test]
        public void openItemInHomePageTest()
        {
            // Feature: Abrir um item da Home Page

            home.openItemInHomePage();

            driver.Dispose();
        }*/

        [Test]
        public void searchForAnItemAndOpenAnItemTest()
        {
            // Feature: Abrir um item da Home Page

            home.searchForAnItem();

            driver.Dispose();
        }
    }
}
