using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class SmsMessage:Message
    {
        public SmsMessage(string text) : base(text)
        {
        }

    }
}
