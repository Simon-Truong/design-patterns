using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class Server : IServer
    {
        public void GreetCustomer()
        {
            Console.WriteLine("Greet customer");
        }

        public void ProcessTransactions()
        {
            Console.WriteLine("Processing payments");
        }

        public void ServeCustomer()
        {
            Console.WriteLine("Serving customer");
        }
    }
}
