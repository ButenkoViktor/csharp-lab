using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Singers<T> : List<T> where T : ISinger 
    {
        
    }
}

