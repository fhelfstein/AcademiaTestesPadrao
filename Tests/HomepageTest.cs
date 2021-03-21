using AcademiaTestePadra.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademiaTestePadra.Tests
{
    class HomepageTest: DriverManager
    {
        private HomePage_Model home;
        public homepageTest() : base()
        {
            home = new HomePage_Model(this.driver);
        }

    }
}
