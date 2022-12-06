using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinterestTest.Helpers
{
    public class PageHelper
    {
        AppManager app;
        public static bool onEditPage = false;
        public PageHelper(AppManager app)
        {
            this.app = app;
        }
        public void OpenProfileEditPage()
        {
            if (onEditPage) return;
            onEditPage = true;
            app.driver.FindElement(By.CssSelector(".Jea > svg")).Click();
            Thread.Sleep(2000);
            app.driver.FindElement(By.CssSelector(".xuA > .zI7 > .RCK .tBJ")).Click();
        }
    }
}
