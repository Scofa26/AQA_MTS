using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class ObjectPerson
    {
        public ObjectPerson(object id, string name)
        {
            Id = id;
            Name = name;
        }

        public object Id { get; }
        public string Name { get; }
    }
}
