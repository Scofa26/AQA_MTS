using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueOfObjects.Models
{
    internal class User
    {

        public string? Fullname { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
