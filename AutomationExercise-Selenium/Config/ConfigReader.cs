using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationExercise_Selenium.Config
{
    public static class ConfigReader
    {
        public static IConfigurationRoot Configuration { get; } = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

        public static string SystemUnderTest => Environment.GetEnvironmentVariable("SystemUnderTest") ?? Configuration["SystemUnderTest"];
        public static string Browser => Environment.GetEnvironmentVariable("Browser") ?? Configuration["Browser"];
        public static string ApplicationUrl => Environment.GetEnvironmentVariable("ApplicationUrl") ?? Configuration["ApplicationUrl"];
        public static string Email => Environment.GetEnvironmentVariable("Email") ?? Configuration["Email"];
        public static string Password => Environment.GetEnvironmentVariable("Password") ?? Configuration["Password"];


        public static string TestAppPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\apps\"));

    }
}
