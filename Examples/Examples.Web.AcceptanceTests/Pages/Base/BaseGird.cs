using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace Examples.Web.AcceptanceTests.Pages.Base
{
    public class BaseGird : BaseModule
    {
        public BaseGird(IWebElement ele) : base(ele)
        {

        }

        public BaseGird(IWebElement ele, List<Column> cols, List<Row> rows) : base(ele)
        {
            Columns = cols;
            Rows = rows;
        }

        public BaseGird(IWebElement ele, List<By> colSelectors, List<By> rowSelectors) : base(ele)
        {
            Columns = colSelectors.Select(s =>
             new Column
             {
                 Cell = new Cell
                 {
                     Element = ele.FindElement(s)
                 }
             });

            Rows = rowSelectors.Select(s => new Row
            {

            });
        }

        public IEnumerable<Column> Columns { get; set; }

        public IEnumerable<Row> Rows { get; set; }

        public void AssertRow(List<string> expecteds, string key)
        {
            List<string> actuals = new List<string>();

            var cells = Rows.First(r => r.Key == key).Cells.Where(c => c.Ignored);

            foreach (var item in cells)
            {
                switch (item.HowVerify)
                {
                    case HowVerify.Text:
                        actuals.Add(item.Element.Text);
                        break;
                    case HowVerify.Value:
                        actuals.Add(item.Element.GetAttribute("value"));
                        break;
                    case HowVerify.Class:
                        actuals.Add(item.Element.GetAttribute("class"));
                        break;
                    default:
                        break;
                }
            }

            CollectionAssert.AreEqual(expecteds, actuals);
        }
    }

    public class Column
    {
        public Cell Cell { get; set; }

        public bool CanSort { get; set; }
    }

    public class Row
    {
        public IList<Cell> Cells { get; set; }

        public string Key { get; set; }
    }

    public class Cell
    {
        public IWebElement Element { get; set; }

        public bool Ignored { get; set; }

        public HowVerify HowVerify { get; set; }
    }

    public enum HowVerify
    {
        Text,
        Value,
        Class
    }
}
