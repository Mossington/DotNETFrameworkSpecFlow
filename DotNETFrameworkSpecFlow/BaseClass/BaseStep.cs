using DotNETFrameworkSpecFlow.AutomationFramework.DriverClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements.BaseBySelector;

namespace DotNETFrameworkSpecFlow.BaseClass
{
    [Binding]
    public sealed class BaseStep
    {
        public static IWebDriver browserInstance;

        internal static string Environment => ConfigurationManager.AppSettings["Host"];
        public static string hubooHomePage => Environment + ConfigurationManager.AppSettings["huboo"];

        [BeforeScenario]
        public static void BeforeEachTest()
        {
            if (!ScenarioContext.Current.ScenarioInfo.Tags.Contains("no_browser")){
                if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Firefox")){
                    browserInstance = Driver.InitializeFireFox();
                }else if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("InternetExplorer")){
                    browserInstance = Driver.InitializeInternetExplorer();
                }else{
                    browserInstance = Driver.InitializeChrome();
                }
            }

            browserInstance.Navigate().GoToUrl(hubooHomePage);
            browserInstance.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll")).Click();
        }

        [AfterScenario]
        public static void AfterEachTest()
        {
            if (!ScenarioContext.Current.ScenarioInfo.Tags.Contains("no_browser")){
                browserInstance.Close();
                browserInstance.Quit();
            }
        }

        public static IWebElement WaitForElementToBeReady(SelectBy selectBy, string Element)
        {
            By SelectByElement = BySelector(selectBy, Element);
            WebDriverWait wait = new WebDriverWait(BaseStep.browserInstance, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(SelectByElement));
            return BaseStep.browserInstance.FindElement(SelectByElement);
        }
    }
}
