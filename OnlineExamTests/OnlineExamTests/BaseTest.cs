using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamTests
{
    public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Dispose();
            }
        }
    }
}
