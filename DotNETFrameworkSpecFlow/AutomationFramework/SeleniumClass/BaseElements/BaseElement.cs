using DotNETFrameworkSpecFlow.BaseClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements
{
    public class BaseElement
    {
        protected IWebElement FindElement(By by)
        {
            WebDriverWait wait = new WebDriverWait(BaseStep.browserInstance, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
            return BaseStep.browserInstance.FindElement(by);
        }

        protected ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            WebDriverWait wait = new WebDriverWait(BaseStep.browserInstance, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));
            return BaseStep.browserInstance.FindElements(by);
        }
    }
}
