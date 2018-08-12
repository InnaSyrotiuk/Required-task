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
            driver.GoToUrl(BaseUrl);
            var loginButton = driver.FindElementByXpath("//a[@href='/Account/Login']");
            loginButton.Click();
            var inpuEmail = driver.FindElementByXpath("//*[contains(@id,'emailLogin')]");
            inpuEmail.SendKeys("teacher@gmail.com");
            var inputPassword = driver.FindElementByXpath("//*[contains(@id,'passwordLogin')]");
            inputPassword.SendKeys("Teacher_123");
            var signInButton = driver.FindElementByXpath("//*[@value='Sign In']");
            signInButton.Click();

            var navBarElement = driver.FindElementByXpath("//*[@id='gn-menu']//a[contains (@class, 'gn-icon-menu')]");
            navBarElement.Click();

            var courseButton = driver.FindElementByXpath("//a[@href='/CourseManagement']");
            courseButton.Click();

            var addCourseButtton = driver.FindElementByXpath("//a[@href='/CourseManagement/Create']");
            addCourseButtton.Click();

            var newCourseName = "New Course" + Guid.NewGuid().ToString();

            var inputCourseName = driver.FindElementByID("Name");
            inputCourseName.SendKeys(newCourseName);

            var inputCourseDescription = driver.FindElementByXpath("//*[contains(@id, 'Description')]");
            inputCourseDescription.SendKeys("This course for beginners");

            var saveButton = driver.FindElementByXpath("//*[contains(@value, 'Ok')]");
            saveButton.Click();
        
            var savedCourse = driver.FindElementByXpath($"//*[text()='{newCourseName}']");
            var result = savedCourse.Text;
            Assert.AreEqual(newCourseName, result, "New course not found");
                   
        }
    }
}

