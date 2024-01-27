using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_HW.Models
{
    internal record  Client(int Code, int Year, int MonthNum, int Duration)
    {
        public override string ToString()
        {
            return $"Code: {Code}, Year: {Year}, MonthNum: {MonthNum}, Duration: {Duration}";
        }
    }
}
