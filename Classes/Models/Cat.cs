using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public  class Cat
    {
        public string name;
        public int age;
        public int maxFoodCont; 

        public bool Feed(int count )
        {
            return count >= maxFoodCont;
        }
    }
}
