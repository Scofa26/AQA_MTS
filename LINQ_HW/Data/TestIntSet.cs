using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_HW.Data
{
    internal class TestIntSet : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            int[] values = { 1, 1, 2, 2, 3, 4, 5, 5, 6, 6, 7, 8 };

            foreach (int i in values) { yield return i; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
