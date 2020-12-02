using DotNETFrameworkSpecFlow.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETFrameworkSpecFlow.AutomationFramework.DriverClass
{
    public class Browser
    {
        public static void SwitchToTab(int tab)
        {
            List<string> tabs = new List<string>(BaseStep.browserInstance.WindowHandles);
            BaseStep.browserInstance.SwitchTo().Window(tabs[tab]);
        }

        public static void CloseTab(int tab)
        {
            List<string> tabs = new List<string>(BaseStep.browserInstance.WindowHandles);
            BaseStep.browserInstance.SwitchTo().Window(tabs[tab]);
            BaseStep.browserInstance.Close();
        }
    }
}
