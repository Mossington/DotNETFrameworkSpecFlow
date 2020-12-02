using DotNETFrameworkSpecFlow.AutomationFramework.DriverClass;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements.BaseBySelector;

namespace DotNETFrameworkSpecFlow.SpecFlow.Support.Helpers
{
    public class OnScreenTextHelper
    {
        public static List<string> DeSerializeActualScreenTextCssSeletor(string selector)
        {
            Waits.WaitForElementToBeReady(SelectBy.CssSelector, selector);

            string bodyText = Driver.instance.FindElement(By.CssSelector(selector)).Text;
            string[] multiBodyText = bodyText.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            List<string> actualText = multiBodyText.ToList();
            return actualText;
        }

        public static List<string> DeSerializeActualScreenTextString(string ScreenText)
        {
            string[] result = ScreenText.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            List<string> actualText = result.ToList();
            return actualText;
        }

        public static List<string> DeSerializeExpectedScreenTextString(string ScreenText)
        {
            return DeSerializeActualScreenTextString(ScreenText);
        }
    }
}
