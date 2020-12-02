using DotNETFrameworkSpecFlow.AutomationFramework.DriverClass;
using DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements;
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
    public class DropDown : BaseElement
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
                this.SelectByText(value);
            }
        }


        public DropDown(SelectBy selectBy, string SelectorElement)
        {
            Selector = BySelector(selectBy, SelectorElement);
        }

        private string CurrentValue()
        {
            IWebElement DropDownElement = FindElement(Selector);
            SelectElement DropDownContent = new SelectElement(DropDownElement);
            return DropDownContent.SelectedOption.Text;
        }

        public void SelectByValue(String value)
        {
            IWebElement DropDownElement = FindElement(Selector);
            SelectElement DropDownContent = new SelectElement(DropDownElement);
            DropDownContent.SelectByValue(Value);
        }

        public void SelectByText(String value)
        {
            IWebElement DropDownElement = FindElement(Selector);
            SelectElement DropDownContent = new SelectElement(DropDownElement);
            DropDownContent.SelectByText(Value);
        }

        public void IsReady()
        {
            WebDriverWait wait = new WebDriverWait(Driver.instance, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Selector));
        }
    }
}
