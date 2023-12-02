using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Client
    {
        public int Id;
        public string PhoneNumber;
        public string Email;

        public void Activate() { }
        public void Pause() { }
        public void Deactivate() { }

        public Client(int id)
        {
            Id = id;
        }

    }
}
