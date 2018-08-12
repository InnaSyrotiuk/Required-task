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

     

        public Header()
        {
            //this.driver = driver;
            Initialize();
        }


        public override void Initialize()
        {
            changeLanguageSelectElement = driver.FindElementByCssSelector("#requestCulture_RequestCulture_UICulture_Name");
            homePageLinkElement = driver.FindElementByCssSelector("#gn-menu > li:nth-child(2) > a");
            signOutButtonElement = driver.FindElementByCssSelector(@"[href*='/Account/Login']");
            signInLinkElement = driver.FindElementByCssSelector("submitLogin");
            signUpLinkElement = driver.FindElementByCssSelector(@"[href *= '/Account/Register']");
            userAccountManageLinkElement = driver.FindElementByCssSelector("#gn-menu > li:nth-child(3) > a:nth-child(1)");
        }
    

    }
}
