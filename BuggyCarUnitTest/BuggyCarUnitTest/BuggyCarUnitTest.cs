using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BugggyCarUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;
        [TestInitialize]
        public void Setup()
        {
            // Initialize the ChromeDriver
            driver = new ChromeDriver();

            // Maximize the browser window
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Done()
        {
            // Initialize the ChromeDriver
            driver.Close();
        }

        [TestMethod]
        public void Login_Successful()
        {
            // Navigate to the Login page
            driver.Navigate().GoToUrl("https://buggy.justtestit.org/");

            // Enter invalid login credentials
            driver.FindElement(By.Name("login")).SendKeys("Hello321");
            driver.FindElement(By.Name("password")).SendKeys("Hello234*");

            // Click on the Login button
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // Verify that the user is logged in and on the Home page
            Assert.IsTrue(driver.FindElement(By.CssSelector("a[class='nav-link']")).Displayed, "Logout");

        }

        [TestMethod]
        public void Login_InvalidCredentials()
        {
            // Navigate to the Login page
            driver.Navigate().GoToUrl("https://buggy.justtestit.org/");

            // Enter invalid login credentials
            driver.FindElement(By.Name("login")).SendKeys("invaliduser");
            driver.FindElement(By.Name("password")).SendKeys("invalidpassword");

            // Click on the Login button
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            // Verify that an error message is displayed
            Assert.IsTrue(driver.FindElement(By.CssSelector("span[class='label label-warning']")).Displayed, "Invalid username/password");
        }

        [TestMethod]
        public void Logout_Successful()
        {
            // Navigate to the Login page
            driver.Navigate().GoToUrl("https://buggy.justtestit.org/");

            // Enter invalid login credentials
            driver.FindElement(By.Name("login")).SendKeys("Hello321");
            driver.FindElement(By.Name("password")).SendKeys("Hello234*");

            // Click on the Login button
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("(//a[contains(text(),'Logout')])")).Click();
            // Verify that the user is logged out and on the Home page
            Assert.IsNotNull(driver.FindElement(By.XPath("(//button[contains(text(),'Login')])")));

        }

        [TestMethod]
        public void Register_Successful()
        {
            // Navigate to the Register page
            driver.Navigate().GoToUrl("https://buggy.justtestit.org/register");
            string uuid = Guid.NewGuid().ToString();
            // Fill out the registration form
            driver.FindElement(By.Id("username")).SendKeys("testUserName" + uuid);
            driver.FindElement(By.Id("firstName")).SendKeys("testFirstName");
            driver.FindElement(By.Id("lastName")).SendKeys("testLastName");
            driver.FindElement(By.Id("password")).SendKeys("testPassword123*");
            driver.FindElement(By.Id("confirmPassword")).SendKeys("testPassword123*");

            // Click on the Register button
            driver.FindElement(By.XPath("(//button[contains(text(),'Register')])")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Verify that register works
            Assert.IsTrue(driver.FindElement(By.CssSelector("div[class='result alert alert-success']")).Displayed, "Registration is successful");

        }

        [TestMethod]
        public void DisplayOverall_Successful()
        {
            // Navigate to the Register page
            driver.Navigate().GoToUrl("https://buggy.justtestit.org/overall");

            // Wait to load
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Verify that records are displayed
            Assert.AreNotEqual(driver.FindElements(By.TagName("td")).Count, 0);

        }

    }
}