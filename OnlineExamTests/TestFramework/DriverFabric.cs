using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class DriverFabric
    {
        static IWebDriver Driver { get; set; }

        public static ExtDriver GetDriver()
        {
            if (Driver == null)
            {
                Driver = new ChromeDriver();

            }
            var driver = new ExtDriver();
            driver.SetDriver(Driver);
            return driver;
        }

        public static void CleanUp()
        {
            if (Driver != null)
            {
                Driver.Close();
                Driver.Dispose();
                Driver = null;
            }
        }
    }
}
