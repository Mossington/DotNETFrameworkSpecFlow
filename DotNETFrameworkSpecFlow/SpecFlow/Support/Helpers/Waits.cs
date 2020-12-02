using DotNETFrameworkSpecFlow.BaseClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements.BaseBySelector;

namespace DotNETFrameworkSpecFlow.SpecFlow.Support.Helpers
{
    public class Waits
    {
        public static IWebElement WaitForElementToBeReady(SelectBy selectBy, string Element)
        {
            By SelectByElement = BySelector(selectBy, Element);
            WebDriverWait wait = new WebDriverWait(BaseStep.browserInstance, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(SelectByElement));
            return BaseStep.browserInstance.FindElement(SelectByElement);
        }
    }
}
