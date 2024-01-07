using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Pages
{
    public class Inventory
    {
        IWebDriver driver;
        public Inventory(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement MenuButton => driver.FindElement(By.Id("react-burger-menu-btn"));
        public IWebElement LogoutButton => driver.FindElement(By.Id("logout_sidebar_link"));
        public IWebElement CartButton => driver.FindElement(By.Id("shopping_cart_container"));

        public void Logout()
        {
            MenuButton.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(LogoutButton));
            LogoutButton.Click();
        }
    }
}
