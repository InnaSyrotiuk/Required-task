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

    public class LogInTest
    {
        public static string BaseUrl = "http://localhost:55842/";
        IWebDriver driver = new ChromeDriver();
        public void ExecuteLogin()
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
        }
        [Test]
        public void LoginTest()
        {
            ExecuteLogin();
            var expectedResult = "student2@gmail.com";
            var userButton = driver.FindElement(By.XPath("//a[@href='/User']"));
            var result = userButton.Text;
            StringAssert.AreEqualIgnoringCase(expectedResult, result, "Button in Header does not match with user name");
            //Assert.AreSame(expectedResult, result"Button in Header does not match with user name");

        }
 
}
}
