using DotNETFrameworkSpecFlow.AutomationFramework.DriverClass;
using DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements;
using DotNETFrameworkSpecFlow.SpecFlow.Support.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements.BaseBySelector;

namespace DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.OnPageActions
{
    public class RadioButton : BaseElement
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
                this.Check(value);
            }
        }


        public RadioButton(SelectBy selectBy, string SelectorElement)
        {
            Selector = BySelector(selectBy, SelectorElement);
        }

        private string CurrentValue()
        {
            return FindElement(Selector).GetAttribute("value");
        }

        public void Check(String value)
        {
            IWebElement ParentElement = FindElement(Selector);
            ReadOnlyCollection<IWebElement> ChildElements = ParentElement.FindElements(By.TagName("label"));
            bool ValueMatchfound = false;

            foreach (var element in ChildElements)
            {
                if (element.Text == value)
                {
                    element.Click();
                    ValueMatchfound = true;
                    break;
                }
            }
            if (ValueMatchfound.Equals(false))
            {
                Exceptions.RadioButtonException(value, Selector);
            }
        }

        public void IsReady()
        {
            WebDriverWait wait = new WebDriverWait(Driver.instance, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(Selector));
        }
    }
}
