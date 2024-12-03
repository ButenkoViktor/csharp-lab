using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Mammal : Animal
    {
        public override string ProduceMilk()
        {
            Console.WriteLine("I make a milk for my little children.");
        }
    }
}
