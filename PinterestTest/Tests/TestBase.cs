using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V105.DOM;
using PinterestTest.Helpers;
using PinterestTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinterestTest.Tests
{
    public class TestBase
    {
        private AppManager app;
        //public static bool authorized = false;
        public TestBase(AppManager app)
        {
            this.app = app;
            Initialize();
        }
        public void Initialize()
        {
            //app.driver.Navigate().GoToUrl(Settings.BaseURL);
            //app.driver.Manage().Window.Size = new System.Drawing.Size(1054, 808);
        }

        public void AddProfileDescription(ProfileData data)
        {
            new AddProfileDescriptionTest().addProfileDescription(data);
        }

        public void EditProfileDescription(ProfileData data)
        {
            new EditProfileDescriptionTest().editProfileDescription(data);
        }

        public void Authorize(string email, string password)
        {
            new AuthorizeTest().authorize(email, password);
        }
    }
}
