using PinterestTest.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinterestTest.Tests
{
    internal class AuthBase : TestBase
    {
        AppManager app;
        public AuthBase(AppManager app) : base(app)
        {
            this.app = app;
        }
        string AuthorizedAs;
        public new void Authorize(string login, string password)
        {
            if (AuthorizedAs != login)
            {
                Console.WriteLine($"Авторизован как {AuthorizedAs ?? "никто"}, выполняю авторизацию как {login}...");
                AuthorizedAs = login;
                if (AuthorizedAs is not null)
                {
                    Logout();
                    //app.driver.Navigate().GoToUrl(Settings.BaseURL);
                }
                base.Authorize(login, password);
            } else
            {
                Console.WriteLine($"Авторизован как {AuthorizedAs}, пропускаю.");
            }
        }
        public void Logout() {
            app.driver.Navigate().GoToUrl($"{Settings.BaseURL}/logout");
            Thread.Sleep(1000);
        }
    }
}
