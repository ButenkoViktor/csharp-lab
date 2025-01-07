using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Child : Human, ISinger
    {
        public Child(string name)
        {
            Name = name;
        }
        public string Sing()
        {
            //Console.WriteLine($"$Child who songs:{Name}");
            return ("Baby shark doo doo doo doo");
           
        }
    }
}