using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IServer server = new Server();

            server.GreetCustomer();
            server.ServeCustomer();
            server.ProcessTransactions();

            IServer traineeServer = new TraineeServer();
            traineeServer.GreetCustomer();
            traineeServer.ServeCustomer();
            traineeServer.ProcessTransactions();

            Console.ReadKey();
        }
    }
}
