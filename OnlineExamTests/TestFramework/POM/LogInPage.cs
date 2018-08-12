using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.POM
{
    public class LogInPage: BasePage
    {
        public IWebElement emailInput { get; set; }
        public IWebElement passwordInput { get; set; }
        public IWebElement rememberMeCheckBox { get; set; }
        public IWebElement signInInputSubmit { get; set; }

        

        public LogInPage()
        {
            Initialize();
        }


        public override void Initialize()
        {
            emailInput = driver.FindElementByID("emailLogin");
            passwordInput = driver.FindElementByID("passwordLogin");
            rememberMeCheckBox = driver.FindElementByID("RememberMe");
            signInInputSubmit = driver.FindElementByID("submitLogin");
        }

        public void SignIn(string email, string password)
        {
            emailInput.SendKeys(email);
            passwordInput.SendKeys(password);
            rememberMeCheckBox.Click();
            signInInputSubmit.Click();

        }
    }
}
