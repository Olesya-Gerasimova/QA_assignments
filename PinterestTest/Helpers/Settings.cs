using PinterestTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace PinterestTest.Helpers
{
    public static class Settings
    {
        static XmlSerializer serializer = new XmlSerializer(typeof(SettingsData));
        public static string file = "../../../Settings.xml";
        static SettingsData data;
        static Settings()
        {
            /*using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                data = new SettingsData
                {
                    BaseURL = "https://ru.pinterest.com/",
                    Login = "ogerasimova966@gmail.com",
                    Password = "Jktcz2002.)"
                };
                serializer.Serialize(fs, data);
            }*/
            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                data = serializer.Deserialize(fs) as SettingsData;
            }
        }
        public static string BaseURL
        {
            get
            {
                return data.BaseURL;
            }
        }
        public static string Login
        {
            get
            {
                return data.Login;
            }
        }
        public static string Password
        {
            get
            {
                return data.Password;
            }
        }
    }

}
