using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class ExtDriver
    {
        private IWebDriver driver;
        public void SetDriver(IWebDriver dr)
        {
            driver = dr;
        }

        public void Close()
        {
            driver.Close();

        }

        public void Dispose()
        {
            driver.Dispose();
        }

        public void GoToUrl(string BaseUrl)
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public IWebElement FindElementByXpath(string Xpath)
        {
            return driver.FindElement(By.XPath(Xpath));
            
        }

        public IWebElement FindElementByID(string id)
        {
            return driver.FindElement(By.Id(id));

        }
        public List<IWebElement> FindElementsByXpath(string Xpath)
        {
            return driver.FindElements(By.XPath(Xpath)).ToList();

        }

        public IWebElement FindElementByCssSelector(string CssSelector)
        {
            return driver.FindElement(By.CssSelector(CssSelector));

        }

    }
}
