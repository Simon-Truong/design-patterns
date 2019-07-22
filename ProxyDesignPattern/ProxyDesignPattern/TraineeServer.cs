using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class TraineeServer : IServer
    {
        private IServer _server = new Server();
        public void GreetCustomer()
        {
            Console.WriteLine("Greet customer attentively");
        }

        public void ProcessTransactions()
        {
            _server.ProcessTransactions();
        }

        public void ServeCustomer()
        {
            Console.WriteLine("Serve customer attentively");
        }
    }
}
