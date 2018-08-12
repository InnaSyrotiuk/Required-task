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
    public class DeleteCourse : BaseTest
    {
        public static string BaseUrl = "http://localhost:55842/";

        [Test]
        public void DeleteCourseTest()
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

            var myCourseButton = driver.FindElementByXpath("//a[@href='/CourseManagement/ViewCourses']");
            myCourseButton.Click();

            bool isDeleteVerified = false;
            var listCourses = driver.FindElementsByXpath("//*[@class='table']//tr");
            var cousesExist = listCourses != null && listCourses.Any();
            Assert.True(cousesExist, "Not found any courses");
            if (listCourses != null)
            {

                foreach (IWebElement row in listCourses)
                {
                    try
                    {
                        var nameElement = row.FindElement(By.XPath(".//*[text()='New Courseb76eda36-02b0-4968-acd7-a881f01df4eb']"));
                        if (nameElement != null)
                        {
                            var deleteButton = row.FindElement(By.XPath(".//a[text()='Delete']"));
                            deleteButton.Click();
                        }
                    }
                    catch (Exception e)
                    {

                    }
                }

            }

            listCourses = driver.FindElementsByXpath("//*[@class='table']//tr");
            foreach (IWebElement row in listCourses)
            {
                try
                {
                    var nameElement = row.FindElement(By.XPath(".//*[text()='New Courseb76eda36-02b0-4968-acd7-a881f01df4eb']"));
                    if (nameElement != null)
                    {
                        var recoverButton = row.FindElement(By.XPath(".//a[text()='Recover']"));
                        var result = recoverButton.Text;
                        StringAssert.AreEqualIgnoringCase("Recover", result, "Delete is not work");
                        isDeleteVerified = true;
                    }
                }
                catch (Exception e)
                {

                }
            }
            Assert.True(isDeleteVerified, "Courses not deleted");

        }
    }
}
