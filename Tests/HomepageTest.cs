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

        [Test]
        public void primeiro()
        {

            home.openItemInHomePage();

            //driver.Dispose();
        }

    }
}
