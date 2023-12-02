using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public  class CorpClient : Client
    {
        public string INN;
        public string UNP;

        public CorpClient(int id) : base(id)
        {
            Console.WriteLine("Corporate Base HashCode: " + base.GetHashCode());
        }
    }
}
