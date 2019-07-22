using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public interface IServer
    {
        void GreetCustomer();
        void ServeCustomer();
        void ProcessTransactions();
    }
}
