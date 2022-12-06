using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PinterestTest.Tests
{
    public class AuthorizeTest
    {
        private AppManager app;
        public AuthorizeTest()
        {
            this.app = AppManager.GetInstance();
        }

        public void authorize(string email, string password)
        {
            //if (TestBase.authorized) return;
            //TestBase.authorized = true;

            //driver.FindElement(By.XPath("//div[@data-test-id=\"simple-login-button\"]")).FindElement(By.TagName("button")).Click();
            app.driver.FindElement(By.CssSelector("[data-test-id='simple-login-button'] button")).Click();
            Thread.Sleep(3000);
            app.driver.FindElement(By.Id("email")).Click();
            app.driver.FindElement(By.Id("email")).SendKeys(email);
            app.driver.FindElement(By.Id("password")).Click();
            app.driver.FindElement(By.Id("password")).SendKeys(password);
            app.driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            Thread.Sleep(2000);
        }
    }
}
