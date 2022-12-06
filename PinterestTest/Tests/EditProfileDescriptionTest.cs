using OpenQA.Selenium;
using PinterestTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinterestTest.Tests
{
    public class EditProfileDescriptionTest
    {
        AppManager app;
        public EditProfileDescriptionTest()
        {
            this.app = AppManager.GetInstance();
        }
        public void editProfileDescription(ProfileData data)
        {
            Thread.Sleep(5000);
            app.driver.FindElement(By.Id("about")).Click();
            ((IJavaScriptExecutor)app.driver).ExecuteScript("document.getElementById(\"about\").value = ''");
            Thread.Sleep(2000);
            app.driver.FindElement(By.Id("about")).SendKeys(data.Description);
            app.driver.FindElement(By.CssSelector("[data-test-id='done-button'] button")).Click();
        }
    }
}
