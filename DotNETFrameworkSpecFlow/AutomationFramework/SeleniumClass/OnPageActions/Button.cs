using DotNETFrameworkSpecFlow.AutomationFramework.DriverClass;
using DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements;
using DotNETFrameworkSpecFlow.BaseClass;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements.BaseBySelector;

namespace DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.OnPageActions
{
    public class Button : BaseElement
    {
        private By Selector { get; set; }

        public string Value
        {
            get
            {
                return CurrentValue();
            }
            set
            {
                //
            }
        }


        public Button(SelectBy selectBy, string SelectorElement)
        {
            Selector = BySelector(selectBy, SelectorElement);
        }

        private string CurrentValue()
        {
            return FindElement(Selector).Text;
        }

        public void Click()
        {
            FindElement(Selector).Click();
        }

        public bool IsEnabled()
        {
            return BaseStep.browserInstance.FindElement(Selector).Enabled;
        }

        public void IsReady()
        {
            WebDriverWait wait = new WebDriverWait(Driver.instance, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Selector));
        }
    }
}
