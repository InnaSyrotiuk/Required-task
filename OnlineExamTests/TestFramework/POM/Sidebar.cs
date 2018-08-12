using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.POM
{
    public class SideBar :BasePage
    {
        public SideBar(IWebDriver driver) : base(driver)
        {
            Initialize();
        }

        public IWebElement adminPanelMenuItemElement { get; set; }
        public IWebElement newsMenuItemElement { get; set; }
        public IWebElement ratingsMenuItemElement { get; set; }
        public IWebElement coursesMenuItemElement { get; set; }
        public IWebElement codeHistoryMenuItemElement { get; set; }
        public IWebElement mailBoxMenuItemElement { get; set; }
        public IWebElement contactUsMenuItemElement { get; set; }

        

        //public SideBar(IWebDriver driver) :base()
        //{
        //    this.driver = driver;
        //    Initialize();
        //}


        public override void Initialize()
        {
            adminPanelMenuItemElement = driver.FindElement(By.XPath("//a[@href='/AdminPanel/Users']"));
            newsMenuItemElement = driver.FindElement(By.CssSelector("a[href*='/AddNews/News']"));
            ratingsMenuItemElement = driver.FindElement(By.XPath("//a[@href='/UserRating']"));
            coursesMenuItemElement = driver.FindElement(By.XPath("//a[@href='/CourseManagement']"));
            codeHistoryMenuItemElement = driver.FindElement(By.CssSelector(@"a[href*='/CodeHistory/History']"));
            mailBoxMenuItemElement = driver.FindElement(By.XPath("//a[@href='/EmailMessages']"));
            contactUsMenuItemElement = driver.FindElement(By.CssSelector(@"a[href*='/EmailMessages/GetEmail']"));
        }
        
        
        

    }
}
