using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectStepsHW.Elements
{
    internal class TableRow
    {
        private UIElement _uiElement;
        private List<TableCell> _cells;

        public TableRow(UIElement uiElement)
        {
            _uiElement = uiElement;
            _cells = new List<TableCell>();

            foreach (var cellElement in _uiElement.FindUIElements(By.TagName("td")))
            {
                _cells.Add(new TableCell(cellElement));
            }
        }

        public TableCell GetCell(int columnIndex)
        {
            return _cells[columnIndex];
        }
    }
}
