using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.POM
{
    public class Header : BasePage
    {
        public IWebElement changeLanguageSelectElement { get; set; }
        public IWebElement homePageLinkElement { get; set; }
        public IWebElement signOutButtonElement { get; set; }
        public IWebElement signInLinkElement { get; set; }
        public IWebElement signUpLinkElement { get; set; }
        public IWebElement userAccountManageLinkElement { get; set; }

     

        public Header(IWebDriver driver) : base(driver)
        {
            //this.driver = driver;
            Initialize();
        }


        public override void Initialize()
        {
            changeLanguageSelectElement = driver.FindElement(By.CssSelector("#requestCulture_RequestCulture_UICulture_Name"));
            homePageLinkElement = driver.FindElement(By.CssSelector("#gn-menu > li:nth-child(2) > a"));
            signOutButtonElement = driver.FindElement(By.CssSelector(@"[href*='/Account/Login']"));
            signInLinkElement = driver.FindElement(By.CssSelector("submitLogin"));
            signUpLinkElement = driver.FindElement(By.CssSelector(@"[href *= '/Account/Register']"));
            userAccountManageLinkElement = driver.FindElement(By.CssSelector("#gn-menu > li:nth-child(3) > a:nth-child(1)"));
        }
    

    }
}
