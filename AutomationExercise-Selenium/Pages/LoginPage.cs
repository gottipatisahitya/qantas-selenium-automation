using FluentAssertions;
using OpenQA.Selenium;

namespace AutomationExercise_Selenium.Pages
{
    public class LoginPage : BasePage
    {
        private IWebDriver _driver;
        public LoginPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        public void VerifyLoginPageIsDisplayed()
        {
            var loginPageBrowserTitle = _driver.Title;
            loginPageBrowserTitle.Should().Be("Automation Exercise - Signup / Login");
        }

        public void EnterUsername(string username)
        {
            EnterTextInTextBox(By.Name("email"), username);
        }

        public void EnterPassword(string password)
        {
            EnterTextInTextBox(By.Name("password"), password);
        }

        public void ClickLoginButton()
        {
            var loginButton = _driver.FindElement(By.XPath("//button[text()='Login']"));
            loginButton.Click();
            WaitUntilElementIsDisplayed(By.XPath("//a[text()=' Logout']"));
        }

        

        public void LoginToAccount(string email, string password)
        {
            var homePage = new HomePage(_driver);
            homePage.ClickSignUpLoginLinkInHeader();
            EnterUsername(email);
            EnterPassword(password);
            ClickLoginButton();
        }

        public bool VerifyIfLoginIsSuccessful()
        {
            var loginErrorElements = _driver.FindElements(By.XPath("//p[text()='Your email or password is incorrect!']"));
            return loginErrorElements.Count <= 0;
        }


    }
}
