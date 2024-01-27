using LINQ_HW.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HW.Data
{
    internal class TestObjectSet : IEnumerable<Client>
    {
        public IEnumerator<Client> GetEnumerator()
        {
            var list = new List<Client>()
            {
                new Client(1,1,1,1),
                new Client(2,2,2,2),
                new Client(3,3,3,3),
                new Client(4,4,4,4),
                new Client(5,3,4,1),
                new Client(6,4,4,1),
            };

            foreach (Client c in list)
            {
                yield return c;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
