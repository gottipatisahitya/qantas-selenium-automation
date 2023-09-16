using AutomationExercise_Selenium.Config;
using AutomationExercise_Selenium.Pages;
using FluentAssertions;
using NUnit.Framework;

namespace AutomationExercise_Selenium.Tests
{
    [TestFixture]
    public class ProductTests : BaseTest
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
        public void TC8_VerifyAllProductsAndProductDetailPages()
        {
            var homePage = new HomePage(driver);
            homePage.VerifyHomePageIsDisplayed();

            var loginPage = new LoginPage(driver);
            loginPage.LoginToAccount(ConfigReader.Email, ConfigReader.Password);
            var isLoginSuccessful = loginPage.VerifyIfLoginIsSuccessful();
            isLoginSuccessful.Should().Be(true, "login should be successful for correct email and password");

            var productsPage = new ProductsPage(driver);
            productsPage.VerifyAllProductsPageIsDisplayed();
            productsPage.VerifyAllProductsListIsDisplayed();
            productsPage.ClickViewProductByPosition(positionInList: 1);

            var productDetailsPage = new ProductDetailsPage(driver);
            productDetailsPage.VerifyProductsDetailsPageIsDisplayed();
            productDetailsPage.VerifyProductNameIsDisplayed();
            productDetailsPage.VerifyProductCategoryIsDisplayed();
            productDetailsPage.VerifyProductPriceIsDisplayed();
            productDetailsPage.VerifyProductAvailabilityIsDisplayed();
            productDetailsPage.VerifyProductConditionIsDisplayed();
            productDetailsPage.VerifyProductBrandIsDisplayed();

        }

    }
}
