using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitProject
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]

    internal class SeverityAttrimutes : PropertyAttribute
    {
        public SeverityAttrimutes(SeverityLevel level):base(level.ToString()) { } 
    }
}
