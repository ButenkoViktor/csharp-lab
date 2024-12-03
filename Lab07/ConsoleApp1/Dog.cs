using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dog : Animal, Mammal, IWalkable
    {
        public string Sound => "Woof";
        public void Move()
        {
            Console.WriteLine("Running like a dog...");
        }

        public void FetchBall()
        {
            Console.WriteLine("Just throw the ball and I'll fetch it!");
        }
    }
}
