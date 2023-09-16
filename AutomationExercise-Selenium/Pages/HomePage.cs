using FluentAssertions;
using OpenQA.Selenium;

namespace AutomationExercise_Selenium.Pages
{
    public class HomePage : BasePage
    {
        private IWebDriver _driver;
        public HomePage(IWebDriver driver) : base (driver)
        {
            _driver = driver;
        }

        public void VerifyHomePageIsDisplayed()
        {
            var homePageBrowserTitle = _driver.Title;
            homePageBrowserTitle.Should().Be("Automation Exercise", "that is the expected Home Page browser title");
        }

        public void ClickSignUpLoginLinkInHeader()
        {
            _driver.FindElement(By.XPath("//a[text()=' Signup / Login']")).Click();
            WaitUntilElementIsDisplayed(By.XPath("//h2[text()='Login to your account']"));
        }

        public string GetLoggedInAsUser()
        {
            return _driver.FindElement(By.XPath("//a[contains(text(), 'Logged in as')]")).Text;
        }

        public bool VerifyDeleteAccountLinkDisplayed()
        {
            var deleteAccountLink = _driver.FindElement(By.XPath("//div[contains(@class, 'shop-menu')]//a[text()=' Delete Account']"));
            return deleteAccountLink.Displayed;
        }

        public void ClickProductsLinkInHeader()
        {
            _driver.FindElement(By.XPath("//a[text()=' Products']")).Click();
            WaitUntilElementIsDisplayed(By.XPath("//h2[text()='All Products']"));
        }

        public void ClickLogoutButton()
        {
            _driver.FindElement(By.XPath("//a[text()=' Logout']")).Click();
        }
        
    }
}
