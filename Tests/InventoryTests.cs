using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest.Tests
{
    [TestFixture]
    public class InventoryTests
    {
        IWebDriver driver;
        LoginPage loginPage;
        Inventory inventoryPage;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
            inventoryPage = new Inventory(driver);
        }
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
        }
        [SetUp]
        public void Setup()
        {
            loginPage.GoToPage();
            loginPage.Login();
        }

        [Test]
        public void AddAndRemoveItemToCart()
        {
            inventoryPage.AddBackPackItemCart();
            Assert.That(inventoryPage.CartItemsAmount.Text, Is.EqualTo("1"));
            inventoryPage.RemoveBackpackItemCart();
            try
            {
                Assert.IsFalse(inventoryPage.CartItemsAmount.Displayed,"Aun se muestra el icono");               
                
            }catch(NoSuchElementException)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void OrganizeItemsByA_Z()
        {
           inventoryPage.FilterByA_Z();
           Assert.IsTrue(inventoryPage.FirstItemInventory.Text.Contains("Sauce Labs Backpack"));
           Assert.IsTrue(inventoryPage.LastItemIventory.Text.Contains("Test.allTheThings() T-Shirt (Red)"));
        }

        [Test]
        public void OrganizeItemsByZ_A()
        {
            inventoryPage.FilterByZ_A();
            Assert.IsTrue(inventoryPage.FirstItemInventory.Text.Contains("Test.allTheThings() T-Shirt (Red)"));
            Assert.IsTrue(inventoryPage.LastItemIventory.Text.Contains("Sauce Labs Backpack"));
        }
    }
}
