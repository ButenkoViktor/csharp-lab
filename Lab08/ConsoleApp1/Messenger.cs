using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Messenger<T> where T : IMessage
    {
        private T _message;

        public Messenger(T message)
        {
            _message = message;
        }

        public void Send()
        {
            Console.WriteLine($"Sending {typeof(T).Name}: {_message.Content}");
        }
    }
}
