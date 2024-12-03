using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        public string PublicMember { get; set; }
        protected string ProtectedMember { get; set; }
        private string PrivateMember { get; set; }
        
        public const string Kingdom = "Animalia";
        public string Sound { get; set; }
        public void Move()
        {
            Console.WriteLine("Moving...");
        }
        public void FetchBall()
        {
            Console.WriteLine("Just throw the ball and I'll fetch it!");
        }
    }
}
