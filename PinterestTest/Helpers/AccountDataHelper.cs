using OpenQA.Selenium;
using PinterestTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinterestTest.Helpers
{

    public class AccountDataHelper
    {
        AppManager app;
        public AccountDataHelper(AppManager app)
        {
            this.app = app;
        }
        public ProfileData GetEditedGroupData()
        {
            return new ProfileData(app.driver.FindElement(By.Id("about")).Text);
        }

    }
}
