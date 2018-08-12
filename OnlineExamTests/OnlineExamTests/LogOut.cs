using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.POM;

namespace OnlineExamTests
{
    [TestFixture]

    public class LogOutTest: BaseTest
    {
        public static string BaseUrl = "http://localhost:55842/Account/Login";

        [Test]
        public void LogOutTet()
        {
            driver.Navigate().GoToUrl(BaseUrl);
            TestFramework.POM.LogInPage login = new LogInPage(driver);
            login.SignIn("student2@gmail.com", "Student_123");

            var signOutButton = driver.FindElement(By.XPath("//*[contains(@class, 'btn btn-link navbar-btn navbar-link deff ')]"));
            signOutButton.Click();
            var signUpButton = driver.FindElement(By.XPath("//a[@href = '/Account/Register']"));
            var result = signUpButton.Text;
            StringAssert.AreEqualIgnoringCase("SIGN UP", result);
        }


    }
}
