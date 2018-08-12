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

        

        public LogInPage(IWebDriver driver) : base(driver)
        {
            Initialize();
        }


        public override void Initialize()
        {
            emailInput = driver.FindElement(By.Id("emailLogin"));
            passwordInput = driver.FindElement(By.Id("passwordLogin"));
            rememberMeCheckBox = driver.FindElement(By.Id("RememberMe"));
            signInInputSubmit = driver.FindElement(By.Id("submitLogin"));
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
