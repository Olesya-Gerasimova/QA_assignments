using OpenQA.Selenium;
using PinterestTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinterestTest.Tests
{
    public class AddProfileDescriptionTest
    {
        AppManager app;
        public AddProfileDescriptionTest()
        {
            this.app = AppManager.GetInstance();
        }
        public void addProfileDescription(ProfileData data)
        {
            /*Thread.Sleep(2000);
            app.driver.FindElement(By.Id("about")).Click();
            app.driver.FindElement(By.Id("about")).Clear();
            app.driver.FindElement(By.Id("about")).SendKeys(data.Description);
            app.driver.FindElement(By.CssSelector(".Il7")).Click();*/
            Thread.Sleep(2000);
            app.driver.FindElement(By.Id("about")).Click();
            Thread.Sleep(2000);
            app.driver.FindElement(By.Id("about")).SendKeys(data.Description);
            app.driver.FindElement(By.CssSelector("[data-test-id='done-button'] button")).Click();
        }
    }
}
