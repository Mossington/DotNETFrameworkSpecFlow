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
        readonly public static Button TelephoneNumber = new Button(SelectBy.CssSelector, ".tel .tel__link.tel_desktop");
        readonly public static Button LoginButton = new Button(SelectBy.CssSelector, "body > header > div.header-right > div.login > a:nth-child(1)");
        readonly public static Button PricingButton = new Button(SelectBy.CssSelector, ".menu li:nth-child(3) a ");
    }
}
