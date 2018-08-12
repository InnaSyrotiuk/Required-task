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
    public class CreateCourseTest : BaseTest
    {

        public static string BaseUrl = "http://localhost:55842/";

        [Test]
        public void CreateCourseTet()
        {
            driver.Navigate().GoToUrl(BaseUrl);
            var loginButton = driver.FindElement(By.XPath("//a[@href='/Account/Login']"));
            loginButton.Click();
            var inpuEmail = driver.FindElement(By.XPath("//*[contains(@id,'emailLogin')]"));
            inpuEmail.SendKeys("teacher@gmail.com");
            var inputPassword = driver.FindElement(By.XPath("//*[contains(@id,'passwordLogin')]"));
            inputPassword.SendKeys("Teacher_123");
            var signInButton = driver.FindElement(By.XPath("//*[@value='Sign In']"));
            signInButton.Click();

            var navBarElement = driver.FindElement(By.XPath("//*[@id='gn-menu']//a[contains (@class, 'gn-icon-menu')]"));
            navBarElement.Click();

            var courseButton = driver.FindElement(By.XPath("//a[@href='/CourseManagement']"));
            courseButton.Click();

            var addCourseButtton = driver.FindElement(By.XPath("//a[@href='/CourseManagement/Create']"));
            addCourseButtton.Click();

            var newCourseName = "New Course" + Guid.NewGuid().ToString();

            var inputCourseName = driver.FindElement(By.Id("Name"));
            inputCourseName.SendKeys(newCourseName);

            var inputCourseDescription = driver.FindElement(By.XPath("//*[contains(@id, 'Description')]"));
            inputCourseDescription.SendKeys("This course for beginners");

            var saveButton = driver.FindElement(By.XPath("//*[contains(@value, 'Ok')]"));
            saveButton.Click();
        
            var savedCourse = driver.FindElement(By.XPath($"//*[text()='{newCourseName}']"));
            var result = savedCourse.Text;
            Assert.AreEqual(newCourseName, result, "New course not found");
                   
        }
    }
}

