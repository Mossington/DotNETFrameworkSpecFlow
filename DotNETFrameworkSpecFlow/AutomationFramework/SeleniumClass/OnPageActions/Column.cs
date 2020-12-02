using DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements.BaseBySelector;

namespace DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.OnPageActions
{
    public class Column : BaseElement
    {
        private By SelectorTable { get; set; }

        readonly private string HeaderByName;
        readonly private int HeaderByColumnCount;
        private int HeaderIndexByName = 1;
        private int NewHeaderIndex = 0;

        public Column(SelectBy SelectBy_Table, string SelectorTableElement, string _HeaderName = null, int _headerColumnByCount = 0)
        {
            SelectorTable = BySelector(SelectBy_Table, SelectorTableElement);
            HeaderByName = _HeaderName;
            HeaderByColumnCount = _headerColumnByCount;
        }

        private int TableHeaderByCount()
        {
            HeaderIndexByName = 1;
            IWebElement table = FindElement(SelectorTable);
            IList<IWebElement> tableHeaders = table.FindElements(By.TagName("th"));
            foreach (var tableHead in tableHeaders)
            {
                string tableHeadName = tableHead.Text;
                if (tableHeadName == HeaderByName)
                {
                    break;
                }
                HeaderIndexByName++;
            }
            return HeaderIndexByName;
        }

        private int TableHeaderIndex()
        {
            NewHeaderIndex = 0;
            if (HeaderByName == null)
            {
                NewHeaderIndex = HeaderByColumnCount;
            }
            else
            {
                NewHeaderIndex = TableHeaderByCount();
            }
            return NewHeaderIndex;
        }

        public TableCell getCellAtRow(int row)
        {
            TableHeaderIndex();
            return new TableCell(SelectorTable, NewHeaderIndex, row);
        }

        public TableCell ReturnRowNumber()
        {
            TableHeaderIndex();
            return new TableCell(SelectorTable, NewHeaderIndex);
        }
    }
}
