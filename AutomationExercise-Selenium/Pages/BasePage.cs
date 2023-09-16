using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExercise_Selenium.Pages
{
    public class BasePage
    {
        private IWebDriver _driver;
        public WebDriverWait wait;

        public BasePage(IWebDriver driver) 
        {
            _driver = driver;
        }

        public void WaitUntilElementIsDisplayed(By by)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(x => x.FindElement(by).Displayed);
        }

        public void EnterTextInTextBox(By by, string text)
        {
            var element = _driver.FindElement(by);
            element.Click();
            element.Clear();
            element.SendKeys(text);
        }

    }
}
