using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETFrameworkSpecFlow.SpecFlow.Support.Helpers
{
    public class Exceptions
    {
        public static ArgumentException RadioButtonException(string value, By _Selector)
        {
            throw new System.ArgumentException("For element:" + _Selector.ToString() + ", the following field value could not be found", value);
        }

        public static ArgumentException DropDownEmptyException(string value, By _Selector)
        {
            throw new System.ArgumentException("For element:" + _Selector.ToString() + ", the submission route dropdown list is empty");
        }
    }
}
