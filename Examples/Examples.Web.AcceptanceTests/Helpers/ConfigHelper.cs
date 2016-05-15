using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Web.AcceptanceTests.Helpers
{
    public static class ConfigHelper
    {
        public static T Get<T>(string name)
        {
            var value = ConfigurationManager.AppSettings[name];
            AssertHelper.IsNotNull<InvalidOperationException>(value, "AppSetting with name {0} not found. Please check the application configuration file.", name);
            if (typeof(T).IsEnum)
                return (T)Enum.Parse(typeof(T), value);
            return (T)Convert.ChangeType(value, typeof(T));
        }
        public static string GetConnectionString(string name)
        {
            var value = ConfigurationManager.ConnectionStrings[name];
            AssertHelper.IsNotNull<InvalidOperationException>(value, "ConnectionString with name {0} not found. Please check the application configuration file.", name);
            return value.ConnectionString;
        }

        public static TimeSpan ImplicitlyWait
        {
            get
            {
                return TimeSpan.FromSeconds(Get<int>("ImplicitlyWait"));
            }
        }

        public static TimeSpan PageLoadTimeout
        {
            get
            {
                return TimeSpan.FromSeconds(Get<int>("PageLoadTimeout"));
            }
        }

        public static string DriverToUse
        {
            get
            {
                return Get<string>("DriverToUse");
            }
        }
    }
}
