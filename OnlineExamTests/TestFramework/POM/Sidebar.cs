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
        public SideBar()
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
            adminPanelMenuItemElement = driver.FindElementByXpath("//a[@href='/AdminPanel/Users']");
            newsMenuItemElement = driver.FindElementByCssSelector("a[href*='/AddNews/News']");
            ratingsMenuItemElement = driver.FindElementByXpath("//a[@href='/UserRating']");
            coursesMenuItemElement = driver.FindElementByXpath("//a[@href='/CourseManagement']");
            codeHistoryMenuItemElement = driver.FindElementByCssSelector(@"a[href*='/CodeHistory/History']");
            mailBoxMenuItemElement = driver.FindElementByXpath("//a[@href='/EmailMessages']");
            contactUsMenuItemElement = driver.FindElementByCssSelector(@"a[href*='/EmailMessages/GetEmail']");
        }
        
        
        

    }
}
