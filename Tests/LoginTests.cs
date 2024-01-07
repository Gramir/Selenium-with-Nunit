using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTest.Pages;

namespace SeleniumTest.Tests
{
    [TestFixture]
    public class LoginTests
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

        [SetUp]
        public void Setup()
        {
           loginPage.GoToPage();
        }
        
        [Test]
        public void LogInSuccefully()
        {
            
            loginPage.Login();
            Assert.IsTrue(driver.Url.Contains("inventory"));
        }

        [Test]
        public void LogInWithWrongPassword()
        {
            loginPage.Login(null, "wrong_password");
            Assert.IsTrue(loginPage.ErrorMessage.Displayed);
            Assert.That(loginPage.ErrorMessage.Text, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
        }

        [Test]
        public void LogOutSuccefully()
        {
            loginPage.Login();
            inventoryPage.Logout();
            Assert.IsTrue(driver.Url.Contains("saucedemo")); 
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            driver.Quit();
        }
    }
}