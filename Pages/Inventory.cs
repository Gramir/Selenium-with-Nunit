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
        public IWebElement BuyBackPackButton => driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
        public IWebElement CartItemsAmount => driver.FindElement(By.ClassName("shopping_cart_badge"));
        public IWebElement RemoveBackPackButton => driver.FindElement(By.Id("remove-sauce-labs-backpack"));
        public IWebElement Filter => driver.FindElement(By.ClassName("product_sort_container"));
        public IWebElement FirstItemInventory => driver.FindElement(By.CssSelector(".inventory_list>.inventory_item:first-child"));
        public IWebElement LastItemIventory => driver.FindElement(By.CssSelector(".inventory_list>.inventory_item:last-child"));

        public void AddBackPackItemCart()
        {
            BuyBackPackButton.Click();
        }
        public void RemoveBackpackItemCart()
        {
            RemoveBackPackButton.Click();
        }
        public void Logout()
        {
            MenuButton.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(LogoutButton));
            LogoutButton.Click();
        }
        public void FilterByA_Z()
        {
            SelectElement select = new SelectElement(Filter);
            select.SelectByValue("az");
        }
        public void FilterByZ_A()
        {
            SelectElement select = new SelectElement(Filter);
            select.SelectByValue("za");
        }


    }
}
