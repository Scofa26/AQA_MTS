using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Phone
    {
        string number;
        string model;
        int weight;

        public Phone()
        {
            number = "24211";
            model = "S6";
            weight = 1;
        }

        public Phone(string numer, string model) 
        {
            this.number = numer;    
            this.model = model;
        }

        public Phone(string numer, string model, int weight) : this(numer,model) 
        {
            this.number = numer;
            this.model = model;
            this.weight = weight;
        }
        
        public void receiveCall (string callerName)
        {
            Console.WriteLine($"Звонит {callerName}");
        }

        public string getNumber  => number;

        public void sendMessage (params string[] numbers )
        {
            for (int i = 0; i < numbers.Length; i++) Console.WriteLine($"number[{i}] = {numbers[i]}");
        }
        public string Model { get => model; set => model = value; }
        public int Weight { get => weight; set => weight = value; }
    }
}
