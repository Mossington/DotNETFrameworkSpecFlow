using DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.OnPageActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements.BaseBySelector;

namespace DotNETFrameworkSpecFlow.SpecFlow.Support.POM_Pages
{
    public class Page_Login
    {
        //private static TextField email;
        readonly public static TextField password = new TextField(SelectBy.name, "Password");
        readonly public static TextField email = new TextField(SelectBy.name, "Email address");

        //public static TextField email(string paramater)
        //{
        //    return new TextField(SelectBy.name, $"e{paramater}l");
        //}
    }
}
