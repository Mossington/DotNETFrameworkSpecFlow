using DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.BaseElements;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETFrameworkSpecFlow.AutomationFramework.SeleniumClass.OnPageActions
{
    public class TableCell : BaseElement
    {
        readonly private By _TableName;
        readonly private int _row;
        readonly private int _column;

        public string Value
        {
            get
            {
                return CurrentValue();
            }
            set
            {
                this.EnterValue(value);
            }
        }

        public TableCell(By TableName, int columnm, int row = 0)
        {
            _TableName = TableName;
            _column = columnm;
            _row = row;
        }

        private string CurrentValue()
        {
            string _value;
            _value = GetElement().GetAttribute("value");

            if (_value == null)
            {
                _value = GetElement().Text;
            }
            return _value;
        }

        private void EnterValue(string value)
        {
            GetElement().Clear();
            GetElement().SendKeys(value);
        }

        public void Clickcell()
        {
            GetElement().Click();
        }

        public void ClickCellLink()
        {
            IReadOnlyCollection<IWebElement> hrefElements = GetElement().FindElements(By.TagName("[href]")).ToList();
            hrefElements.ElementAt(0).Click();
        }

        public int WhereCellContains(string CellContents)
        {
            int CellIndex = 1;
            int RowIndex = 1;
            bool CellValueFound = false;
            IWebElement table = FindElement(_TableName);
            IReadOnlyCollection<IWebElement> tbodyTds = table.FindElements(By.TagName("tbody>tr")).ToList();
            foreach (var row in tbodyTds)
            {
                CellIndex = 1;
                IReadOnlyCollection<IWebElement> tds = row.FindElements(By.TagName("td"));
                foreach (var cell in tds)
                {
                    if (CellIndex == _column)
                    {
                        if (cell.Text.Contains(CellContents))
                        {
                            CellValueFound = true;
                            break;
                        }
                    }
                    CellIndex++;
                }

                if (CellValueFound == true)
                {
                    break;
                }
                else if (row.GetAttribute("class") == "toggle_Container")
                {
                    RowIndex--;
                }
                RowIndex++;
            }
            return RowIndex;
        }

        private IWebElement GetElement()
        {
            IWebElement table = FindElement(_TableName);
            IReadOnlyCollection<IWebElement> tbodyTds = table.FindElements(By.TagName("tbody>tr")).ToList();
            IWebElement tableRow = tbodyTds.ElementAt(this._row - 1);
            if (tableRow.GetAttribute("class") == "toggle_container")
            {
                tableRow = tbodyTds.ElementAt(this._row);
            }
            IReadOnlyCollection<IWebElement> tds = tableRow.FindElements(By.TagName("td"));

            int index = 0;
            bool found = false;
            foreach (var item in tds)
            {
                if (index == _column)
                {
                    found = true;
                    break;
                }
                index++;
            }
            string ElementText = tds.ElementAt(index - 1).Text;
            return tds.ElementAt(index - 1);
        }
    }
}
