using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DotNETFrameworkSpecFlow.AutomationFramework.DriverClass
{
    public class Driver
    {
        public static IWebDriver instance;

        //public static ChromeOptions DetUpChromeOptions()
        //{
        //    ChromeOptions chromeOptions = new ChromeOptions
        //    {
        //        PageLoadStrategy = PageLoadStrategy.Normal,
        //        AcceptInsecureCertificates = true
        //    };
        //    chromeOptions.AddArgument("--disable-dev-shm-uage");
        //    chromeOptions.AddArgument("--no-sandbox");
        //    chromeOptions.AddArgument("start-maximized");
        //    chromeOptions.AddArgument("disable-infobars");
        //    chromeOptions.AddArgument("--disable-extensions");
        //    chromeOptions.AddArgument("--disable-notifications");
        //    chromeOptions.AddArgument("--disable-popup-blocking");
        //    chromeOptions.AddArgument("--no-proxy-server");
        //    return chromeOptions;
        //}

        public static IWebDriver InitializeChrome()
        {
            //Step1, accept google chrome browser certificates
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AcceptInsecureCertificates = true;

            //Step 2, Path to where chromedriver.exe is stored
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var relativePath = @".";
            var chromeDriverPath = Path.GetFullPath(Path.Combine(outPutDirectory, relativePath));

            //Step 3 Initialze an instance of the chromedriver.exe
            instance = new ChromeDriver(chromeDriverPath, chromeOptions);
            instance.Manage().Window.Maximize();
            instance.Manage().Cookies.DeleteAllCookies();
            return instance;
        }

        public static IWebDriver InitializeFireFox()
        {
            instance = new FirefoxDriver(".");
            instance.Manage().Window.Maximize();
            instance.Manage().Cookies.DeleteAllCookies();
            return instance;
        }

        public static IWebDriver InitializeInternetExplorer()
        {
            instance = new InternetExplorerDriver(".");
            instance.Manage().Window.Maximize();
            instance.Manage().Cookies.DeleteAllCookies();
            return instance;
        }
    }
}
