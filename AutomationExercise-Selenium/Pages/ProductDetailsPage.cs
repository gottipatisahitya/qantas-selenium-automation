using FluentAssertions;
using OpenQA.Selenium;

namespace AutomationExercise_Selenium.Pages
{
    public class ProductDetailsPage : BasePage
    {
        private IWebDriver _driver;
        public ProductDetailsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void VerifyProductsDetailsPageIsDisplayed()
        {
            var productDetailsPageBrowserTitle = _driver.Title;
            productDetailsPageBrowserTitle.Should().Be("Automation Exercise - Product Details");
        }

        public void VerifyProductNameIsDisplayed()
        {
            var productName = _driver.FindElement(By.XPath("//div[@class='product-information']//h2"));
            productName.Displayed.Should().Be(true);
        }

        public void VerifyProductCategoryIsDisplayed()
        {
            var productCategory = _driver.FindElement(By.XPath("//div[@class='product-information']//p[contains(text(), 'Category')]"));
            productCategory.Displayed.Should().Be(true);
        }

        public void VerifyProductPriceIsDisplayed()
        {
            var productPrice = _driver.FindElement(By.XPath("//div[@class='product-information']//span[contains(text(), 'Rs.')]"));
            productPrice.Displayed.Should().Be(true);
        }

        public void VerifyProductAvailabilityIsDisplayed()
        {
            var productAvailability = _driver.FindElement(By.XPath("//div[@class='product-information']//b[text()='Availability:']"));
            productAvailability.Displayed.Should().Be(true);
        }

        public void VerifyProductConditionIsDisplayed()
        {
            var productCondition = _driver.FindElement(By.XPath("//div[@class='product-information']//b[text()='Condition:']"));
            productCondition.Displayed.Should().Be(true);
        }

        public void VerifyProductBrandIsDisplayed()
        {
            var productBrand = _driver.FindElement(By.XPath("//div[@class='product-information']//b[text()='Brand:']"));
            productBrand.Displayed.Should().Be(true);
        }

    }
}
