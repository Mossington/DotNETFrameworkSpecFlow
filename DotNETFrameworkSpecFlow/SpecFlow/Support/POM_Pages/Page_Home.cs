using DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.OnPageActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements.BaseBySelector;

namespace DotNETFrameworkSpecFlow.SpecFlow.Support.POM_Pages
{
    public class Page_Home
    {
        readonly public static Button TelephoneNumber = new Button(SelectBy.CssSelector, "#header > div.header-main__in > div > div.header-group > div.header-contact > a.hc-phone > i");
        readonly public static Button LoginButton = new Button(SelectBy.CssSelector, "#menu-item-35 > a");
        readonly public static Button PricingButton = new Button(SelectBy.CssSelector, "#menu-item-96213 > a");
    }
}
