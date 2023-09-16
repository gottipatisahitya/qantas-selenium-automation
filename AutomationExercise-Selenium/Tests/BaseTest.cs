using AutomationExercise_Selenium.Config;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;

namespace AutomationExercise_Selenium.Tests
{
    [SetUpFixture]
    public class BaseTest
    {
        public static IWebDriver driver;
        public static string appBaseUrl;

        [OneTimeSetUp]
        public static void BrowserLaunch()
        {
            var browsertype = ConfigReader.Browser;
            appBaseUrl = ConfigReader.ApplicationUrl;

            switch (browsertype.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                default:
                    driver = new ChromeDriver();
                    break;
            }

            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
            driver.Navigate().GoToUrl(appBaseUrl);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
