using DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.OnPageActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements.BaseBySelector;

namespace DotNETFrameworkSpecFlow.SpecFlow.Support.POM_Pages
{
    public class Page_Pricing
    {
        public class UKFulfillment_Table
        {
            readonly public static Column SizeAndWeight = new Column(SelectBy.CssSelector, ".table", "Size and weight");
            readonly public static Column Huboo24HourStandard = new Column(SelectBy.CssSelector, ".table", "Huboo 24 Hour Standard");
            readonly public static Column Huboo48HourStandard = new Column(SelectBy.CssSelector, ".table", "Huboo 48 Hour Standard");
        }
    }
}
