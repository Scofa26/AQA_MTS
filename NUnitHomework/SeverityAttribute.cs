using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitHomework
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class SeverityAttribute : PropertyAttribute
    {
        public SeverityAttribute(SeverityLevel level)
          : base(level.ToString()) { }
    }
}
