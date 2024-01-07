using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeleniumTest.Pages
{
    public class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            
        }

        public IWebElement username => driver.FindElement(By.Id("user-name"));
        public IWebElement password => driver.FindElement(By.Id("password"));
        public IWebElement loginButton => driver.FindElement(By.Id("login-button"));
        public IWebElement ErrorMessage => driver.FindElement(By.CssSelector("[data-test=\"error\"]"));

        public void Login(string username=null, string password=null)
        {
            if(username == null)
            {
                username = "standard_user";
            }
            if(password == null)
            {
                password = "secret_sauce";
            }

            this.username.SendKeys(username);
            
            this.password.SendKeys(password);

            loginButton.Click();
        }
    }
}
