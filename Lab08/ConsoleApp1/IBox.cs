using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IBox<T>
    {
        T? Content { get; set; }

        bool isEmpty()
        {
            return Content == null;

        }
    }
}
