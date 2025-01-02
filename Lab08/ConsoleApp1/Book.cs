using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book
    {
        public Book()
        {

        }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"{Title} by {Author}, {Year}";
        }
    }
}
