using FluentAssertions;
using OpenQA.Selenium;

namespace AutomationExercise_Selenium.Pages
{
    public class ProductsPage : BasePage
    {
        private IWebDriver _driver;
        public ProductsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void VerifyAllProductsPageIsDisplayed()
        {
            var allProductsPageBrowserTitle = _driver.Title;
            allProductsPageBrowserTitle.Should().Be("Automation Exercise - All Products");

        }

        public void VerifyAllProductsListIsDisplayed()
        {
            var productsListHeader = _driver.FindElement(By.XPath("//h2[text()='All Products']"));
            productsListHeader.Displayed.Should().Be(true);

            var productsList = _driver.FindElements(By.XPath("//div[@class='features_items']//div[@class='single-products']"));
            productsList.Count.Should().BeGreaterThan(3, "there should be more than 3 products displayed");
        }

        public void ClickViewProductByPosition(int positionInList)
        {
            var viewProductsList = _driver.FindElements(By.XPath("//a[text()='View Product']"));
            viewProductsList[positionInList - 1].Click();
        }

    }
}
