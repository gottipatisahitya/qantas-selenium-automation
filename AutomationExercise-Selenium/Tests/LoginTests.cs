using AutomationExercise_Selenium.Config;
using AutomationExercise_Selenium.Pages;
using AutomationExercise_Selenium.Tests;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationExercise_Selenium
{
    [TestFixture]
    public class LoginTests : BaseTest
    {
        
        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }


        [Test]
        public void TC2_VerifyLoginWithCorrectEmailAndPassword()
        {
            var homePage = new HomePage(driver);
            homePage.VerifyHomePageIsDisplayed();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToAccount(ConfigReader.Email, ConfigReader.Password);
            var isLoginSuccessful = loginPage.VerifyIfLoginIsSuccessful();
            isLoginSuccessful.Should().Be(true, "login should be successful for correct email and password");
            
            var loggedInAsUserText = homePage.GetLoggedInAsUser();
            loggedInAsUserText.Should().Be("Logged in as Sahitya", "that is the name of the logged in user");

            homePage.VerifyDeleteAccountLinkDisplayed().Should().Be(true, 
                "Delete Account button should be dispalyed after successful login");
        }


        [Test]
        public void TC2_VerifyLoginWithInCorrectEmailAndPassword()
        {
            var homePage = new HomePage(driver);
            homePage.VerifyHomePageIsDisplayed();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToAccount("dummy.user@gmail.com", ConfigReader.Password);
            var isLoginSuccessful = loginPage.VerifyIfLoginIsSuccessful();
            isLoginSuccessful.Should().Be(false, "login should not be successful for incorrect email");
        }


    }
}