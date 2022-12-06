using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using PinterestTest.Helpers;
using PinterestTest.Models;
using PinterestTest.Tests;

namespace PinterestTest
{

    public class AppManager
    {
        public IWebDriver driver;
        public IDictionary<string, object> vars { get; private set; }
        private IJavaScriptExecutor js;
        private ProfileData profileData;
        TestBase testBase;
        AuthBase authBase;
        AccountDataHelper accountDataHelper;
        PageHelper pageHelper;
        static AppManager app;
        static bool IsValueCreated = false;
        static public AppManager GetInstance()
        {
            if (!IsValueCreated)
            {
                app = new AppManager();
                IsValueCreated = true;
            }
            return app;
        }
        public AppManager()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<string, object>();
            profileData = new ProfileData("test");
            testBase = new TestBase(this);
            authBase = new AuthBase(this);
            accountDataHelper = new AccountDataHelper(this);
            pageHelper = new PageHelper(this);
        }
        protected void TearDown()
        {
            driver.Quit();
        }
        public void authorization()
        {
            //TestBase testBase = new TestBase(driver);
            //testBase.Initialize();
            authBase.Authorize(Settings.Login, Settings.Password);

        }
        public void addProfileDescription()
        {
            //TestBase testBase = new TestBase(driver);
            //testBase.Initialize();
            authBase.Authorize(Settings.Login, Settings.Password);
            pageHelper.OpenProfileEditPage();
            authBase.AddProfileDescription(profileData);
        }
        public void editProfileDescription()
        {
            //TestBase testBase = new TestBase(driver);
            //testBase.Initialize();
            authBase.Authorize(Settings.Login, Settings.Password);
            pageHelper.OpenProfileEditPage();
            authBase.EditProfileDescription(profileData);
            Thread.Sleep(3000);
            var newProfileData = accountDataHelper.GetEditedGroupData();
            Console.WriteLine($"Expected: {profileData.Description}");
            Console.WriteLine($"Got: {newProfileData.Description}");
            Assert.AreEqual(profileData.Description, newProfileData.Description);
        }
        public void loginWithInvalidData()
        {
            authBase.Authorize("fake", "fake");
        }
        public void Quit()
        {
            driver.Quit();
        }
    }
}