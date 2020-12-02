using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements
{
    public class BaseBySelector
    {
        private static By selector;

        public enum SelectBy
        {
            name,
            Id,
            Class,
            CssSelector,
            xPath,
            LinkText,
            PartialLinkText
        }

        public static By BySelector(SelectBy selectBy, string Selector)
        {
            switch (selectBy)
            {
                case SelectBy.name:
                    selector = By.Name(Selector);
                    break;
                case SelectBy.Id:
                    selector = By.Id(Selector);
                    break;
                case SelectBy.Class:
                    selector = By.ClassName(Selector);
                    break;
                case SelectBy.CssSelector:
                    selector = By.CssSelector(Selector);
                    break;
                case SelectBy.xPath:
                    selector = By.XPath(Selector);
                    break;
                case SelectBy.LinkText:
                    selector = By.LinkText(Selector);
                    break;
                case SelectBy.PartialLinkText:
                    selector = By.PartialLinkText(Selector);
                    break;
            }
            return selector;
        }
    }
}
