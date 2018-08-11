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
    [TestFixture]

    public class LogOutTest
    {
        public static string BaseUrl = "http://localhost:55842/";
        IWebDriver driver = new ChromeDriver();

        [Test]
        public void LogOutTet()
        {
            driver.Navigate().GoToUrl(BaseUrl);
            var loginButton = driver.FindElement(By.XPath("//a[@href='/Account/Login']"));
            loginButton.Click();
            var inpuEmail = driver.FindElement(By.XPath("//*[contains(@id,'emailLogin')]"));
            inpuEmail.SendKeys("student2@gmail.com");
            var inputPassword = driver.FindElement(By.XPath("//*[contains(@id,'passwordLogin')]"));
            inputPassword.SendKeys("Student_123");
            var signInButton = driver.FindElement(By.XPath("//*[@value='Sign In']"));
            signInButton.Click();

            var signOutButton = driver.FindElement(By.XPath("//*[contains(@class, 'btn btn-link navbar-btn navbar-link deff ')]"));
            signOutButton.Click();
            var signUpButton = driver.FindElement(By.XPath("//a[@href = '/Account/Register']"));
            var result = signUpButton.Text;
            StringAssert.AreEqualIgnoringCase("SIGN UP", result);
        }


    }
}
