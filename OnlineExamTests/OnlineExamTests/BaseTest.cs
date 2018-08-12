using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework;

namespace OnlineExamTests
{
    public class BaseTest
    {
        public ExtDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = DriverFabric.GetDriver();
        }

        [TearDown]
        public void TearDown()
        {
            //if (driver != null)
            //{
            //    driver.Close();
            //    driver.Dispose();
            //    driver = null;
            //}
            DriverFabric.CleanUp();
        }

        [OneTimeTearDown]
        public void GlobalTearDown()
        {
            
        }
    }
}
